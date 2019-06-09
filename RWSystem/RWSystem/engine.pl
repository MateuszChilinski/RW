:- use_module(library(ordsets)).

:- consult(temp).

:- dynamic
    causes/3,
    impossible/2,
    negation/2,
    typically_causes/3,
    invokes/4,
    triggers/2,
    releases/3,
    disable_between/3.


%Predicates for H function
addAlternative(H, [], T, H2) :- false.

addAlternative(H, [AlternativeHead | AlternativeTail], T, H2) :-
    union(H, [(AlternativeHead, T)], H2);
    addAlternative(H, AlternativeTail, T, H2);
    (union(H, [(AlternativeHead, T)], HT),
    addAlternative(HT, AlternativeTail, T, H2)).

addFormula(H, [], T, H2) :- union([], H, H2).

addFormula(H, [ConjunctionHead | ConjunctionTail], T, H2) :-
    addAlternative(H, ConjunctionHead, T, HT),
    addFormula(HT, ConjunctionTail, T, H2).

addObservations(H, [], H2) :- H2 = H.

addObservations(H, [(Formula, Timepoint) | ObservationsTail], H2) :-
    addFormula(H, Formula, Timepoint, HT),
    addObservations(HT, ObservationsTail, H2).

hStarAlt(H, [], T) :- false.

hStarAlt(H, [AlternativeHead | AlternativeTail], T) :-
    member((AlternativeHead, T), H) ; 
    hStarAlt(H, AlternativeTail, T) ;
    member((AlternativeHead, T), H) , hStarAlt(H, AlternativeTail, T).

hStar(H, [], T) :- true.

hStar(H, [ConjunctionHead | ConjunctionTail], T) :-
    hStarAlt(H, ConjunctionHead, T),
    hStar(H, ConjunctionTail, T).

complementHistory([], H, H2, Timepoint) :- H2 = H.

complementHistory([Fluent | FluentsTail], H, H2, Timepoint) :-
    T2 is integer(Timepoint) + 1,
    negation(Fluent, Negation),
    (
        member((Fluent, Timepoint), H), not(member((Negation, T2), H)) ->
            union(H, [(Fluent, T2)], HT)
    ;   HT = H
    ),
    complementHistory(FluentsTail, HT, H2, Timepoint).

complementInitialState(H, H1):-
    findall((Fluent, Negation),negation(Fluent,Negation), Contrary),
    fillHistory(Contrary, H, H1).

fillHistory([], H, H).
fillHistory([(Fluent, Negation)|Rest], H, H1):- 
    (
    (\+(member((Fluent, 0), H)), \+(member((Negation, 0), H))) ->
        (
            union(H, [(Fluent, 0)], HT)
            ;
            union(H, [(Negation, 0)], HT)
        )
        ;
        HT = H
    ),
    fillHistory(Rest, HT, H1).
%Predicates for E function
addActions(E, [], E2) :- E2 = E.

addActions(E, [(Action, Timepoint) | ActionsTail], E2) :-
    append(E, [(Action, Timepoint)], ET),
    addActions(ET, ActionsTail, E2).

%Predicates for I
getAllFluents(OldFluents, [], Fluents) :- Fluents = OldFluents.

getAllFluents(OldFluents, [ConjunctionHead | ConjunctionTail], Fluents) :-
    ord_union(OldFluents, ConjunctionHead, TmpFluents),
    getAllFluents(TmpFluents, ConjunctionTail, Fluents).



processImpossible(E,H) :- 
    findall((Action,Condition), impossible(Action,Condition), ImpossibleList),
    processImpossibleStatements(E,H,ImpossibleList).

processImpossibleStatements(E,H,[]).
processImpossibleStatements(E,H,[(Action, Condition)| Rest]):-
    findall(Time, member((Action,Time),E),Timepoints),
    forall(member(Time, Timepoints), \+(hStar(H, Condition, Time))),
    processImpossibleStatements(E, H, Rest).

%Check rules predicates
% CAUSES
process_causes([], H, I, E, N, H2, I2, E2, N2, Timepoint) :-
    H2 = H,
    I2 = I,
    E2 = E,
    N2 = N.

process_causes([(Action, Effect, Condition) | CausesTail], H, I, E, N, H2, I2, E2, N2, Timepoint) :- 
(
    member((Action, Timepoint), E), hStar(H, Condition, Timepoint) ->
        T2 is integer(Timepoint) + 1,
        addFormula(H, Effect, T2, HT),
        (
            member((Action, Timepoint, OldFluents), I) -> 
                delete(I, (Action, Timepoint, _), IT2),
                getAllFluents(OldFluents, Effect, NewFluents),
                union(IT2, [(Action, Timepoint, NewFluents)], IT)
            ;   getAllFluents([], Effect, NewFluents),
                union(I, [(Action, Timepoint, NewFluents)], IT)
        )
;   HT = H, IT = I
),
    process_causes(CausesTail, HT, IT, E, N, H2, I2, E2, N2, Timepoint).

%TYPICALLY CAUSES
process_typically_causes([], H, I, E, N, H2, I2, E2, N2, Timepoint) :-
    H2 = H,
    I2 = I,
    E2 = E,
    N2 = N.

process_typically_causes([(Action, Effect, Condition) | CausesTail], H, I, E, N, H2, I2, E2, N2, Timepoint) :- 
(
    member((Action, Timepoint), E), hStar(H, Condition, Timepoint) -> (
        (
            T2 is integer(Timepoint) + 1,
            addFormula(H, Effect, T2, HT),
            union(N, [(Action, Timepoint)], NT),
            (
                member((Action, Timepoint, OldFluents), I) -> 
                    delete(I, (Action, Timepoint, _), IT2),
                    getAllFluents(OldFluents, Effect, NewFluents),
                    union(IT2, [(Action, Timepoint, NewFluents)], IT)
                ;   getAllFluents([], Effect, NewFluents),
                    union(I, [(Action, Timepoint, NewFluents)], IT)
            )
        ) ;
        (
            HT = H, IT = I, NT = N
        ))

;   HT = H, IT = I, NT = N
),
    process_causes(CausesTail, HT, IT, E, NT, H2, I2, E2, N2, Timepoint).

%INVOKES AFTER
process_invokes([], H, I, E, N, H2, I2, E2, N2, Timepoint) :- 
    H2 = H,
    I2 = I,
    E2 = E,
    N2 = N.

process_invokes([(Action, ResultAction, Period, Condition) | InvokesTail], H, I, E, N, H2, I2, E2, N2, Timepoint) :- 
(
    member((Action, Timepoint), E), hStar(H, Condition, Timepoint) ->
        T2 is integer(Timepoint) + integer(Period),
        union(E, [(ResultAction, T2)], ET)
;   ET = E
),
    process_invokes(InvokesTail, H, I, ET, N, H2, I2, E2, N2, Timepoint).

%TRIGGERS
process_triggers([], H, I, E, N, H2, I2, E2, N2, Timepoint) :- 
    H2 = H,
    I2 = I,
    E2 = E,
    N2 = N.

process_triggers([(Condition, Action) | TriggersTail], H, I, E, N, H2, I2, E2, N2, Timepoint) :- 
(
    hStar(H, Condition, Timepoint) ->
        union(E, [(Action, Timepoint)], ET)
;   ET = E
),
    process_triggers(TriggersTail, H, I, ET, N, H2, I2, E2, N2, Timepoint).

%RELEASES
process_releases([], H, I, E, N, H2, I2, E2, N2, Timepoint) :-
    H2 = H,
    I2 = I,
    E2 = E,
    N2 = N.

process_releases([(Action, Fluent, Condition) | ReleasesTail], H, I, E, N, H2, I2, E2, N2, Timepoint) :-
(
    member((Action, Timepoint), E), hStar(H, Condition, Timepoint) ->
        (
           (
               member((Action, Timepoint, OldFluents), I) -> 
                    delete(I, (Action, Timepoint, _), IT2),
                    NewFluents = [Fluent|OldFluents],
                    union(IT2, [(Action, Timepoint, NewFluents)], IT)
                ;   NewFluents = [Fluent],
                    union(I, [(Action, Timepoint, NewFluents)], IT)
            )
            ,
            (
                (    
                    T2 is Timepoint + 1,
                    negation(Fluent, Negation),
                    (   
                        hStar(H, [[Fluent]], Timepoint) -> 
                            addFormula(H, [[Negation]],T2, HT)
                        ;   addFormula(H, [[Fluent]],T2, HT)
                    )     
                )
                ;
                (
                    HT = H
                )
            ))
        ;
            HT = H, IT = I
),
    process_releases(ReleasesTail, HT, IT, E, N, H2, I2, E2, N2, Timepoint).

% DISABLE

processDisable([]).

processDisable([(Action, Timepoint)|ETail]) :- 
    findall((Start,End), disable_between(Action,Start,End), DisableList),
    processDisableList(DisableList, Timepoint),
    processDisable(ETail).

processDisableList([], Timepoint) :-
    true.

processDisableList([(Start,End)|ListTail], Timepoint) :-
    \+between(Start,End, Timepoint),
    processDisableList(ListTail, Timepoint).


simulate(H, I, E, N, H2, I2, E2, N2, Timepoint, Timeout) :-
    findall((Condition, Action), triggers(Condition, Action), TriggersList),
    process_triggers(TriggersList, H, I, E, N, HT1, IT1, ET1, NT1, Timepoint),

    findall((Action, Effect, Condition), causes(Action, Effect, Condition), CausesList),
    process_causes(CausesList, HT1, IT1, ET1, NT1, HT2, IT2, ET2, NT2, Timepoint),

    findall((Action, Effect, Condition), typically_causes(Action, Effect, Condition), TypicallyCausesList),
    process_typically_causes(TypicallyCausesList, HT2, IT2, ET2, NT2, HT3, IT3, ET3, NT3, Timepoint),

    findall((Action, ResultAction, Period, Condition), invokes(Action, ResultAction, Period, Condition), InvokesList),
    process_invokes(InvokesList, HT3, IT3, ET3, NT3, HT4, IT4, ET4, NT4, Timepoint),

    findall((Action, Fluent, Condition), releases(Action, Fluent, Condition), ReleasesList),
    process_releases(ReleasesList, HT4, IT4, ET4, NT4, HT5, IT5, ET5, NT5, Timepoint),


    findall(Fluent, fluent(Fluent), Fluents),
    complementHistory(Fluents, HT5, HT, Timepoint),
    IT = IT5,
    ET = ET5,
    NT = NT5,

    T2 is integer(Timepoint) + 1,
    (
        T2 < Timeout -> simulate(HT, IT, ET, NT, H2, I2, E2, N2, T2, Timeout)
    ;   H2 = HT, I2 = IT, E2 = ET, N2 = NT
    ).

%Predicate that checks if there is no contradiction
check(H,E) :-
    forall(negation(Fluent, Negation), not((member((Fluent, T), H), member((Negation, T), H)))),
    get_timeout(Timeout),
    forall(between(0, Timeout, Timepoint), ensureNoConcurrency(E, Timepoint)),
    processDisable(E),
    processImpossible(E,H).

ensureNoConcurrency(E, Timepoint):-
    findall(A, member((A, Timepoint), E), CurrentActions),
    length(CurrentActions, NumberOfActions),
    NumberOfActions < 2.
    
cutActionsAfterTimeout(E, E2, Timeout) :-
    findall((Action, Timepoint), ( member((Action, Timepoint), E), Timepoint >= Timeout ), ElementsToRemove),
    subtract(E, ElementsToRemove, E2).

%Predicate that generates all the structures
get_structure(H, I, E, N) :-
    get_all_models(H,I,E,N),
    check(H,E).

get_all_models(H, I, E, N) :-
    get_timeout(Timeout),
    obs(OBS),
    addObservations([], OBS, H1),
    acs(ACS),
    addActions([], ACS, E1),
    complementInitialState(H1, H2),
    simulate(H2, [], E1, [], H, I, E2, N, 0, Timeout),
    cutActionsAfterTimeout(E2, E, Timeout).

get_preferred_models(List) :-
    findall([H,I,E,N], get_structure(H, I, E, N),AllModels),
    checkIfPreferred(AllModels,AllModels,List).

get_timeout(Timeout) :-
    once(disable_between(_, Time, inf)) -> Timeout = Time;
    Timeout = 10.

checkIfPreferred([], AllModels, []).
checkIfPreferred([[H,I,E,N]|Rest], AllModels, NewResult):-
    checkIfPreferred(Rest,AllModels, Result),
    (
        forall(member([H1,I1,E1,N1],AllModels),(\+(subset(N,N1)) ; subset(N1,N) ))->
            NewResult = [[H,I,E,N]| Result]
        ;   NewResult = Result
    ).

possiblySc :-
    once(get_structure(H, I, E, N)).

possiblyAction(Action, Time) :-
    once( ( get_structure(H, I, E, N), member((Action, Time), E) ) ) .

possiblyCondition(Condition, Time) :-
    once( ( get_structure(H, I, E, N), hStar(H, Condition, Time) ) ) .
    
necessaryAction(Action, Time) :-
	necessarySc,
    forall(get_structure(H, I, E, N), member((Action, Time), E)).

necessaryCondition(Condition, Time) :-
	necessarySc,
    forall(get_structure(H, I, E, N), hStar(H, Condition, Time)).

necessarySc :-
    forall(get_all_models(H, I, E, N), check(H,E)).

typicallyCondition(Condition, Time) :-
    get_preferred_models(PreferredModels),
    forall(member([H,I,E,N],PreferredModels), hStar(H, Condition, Time)).