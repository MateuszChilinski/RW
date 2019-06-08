%% historyjka
typicallyCauses(work, [[workDone]], [[not_workDone], [rested]]).

causes(work, [[not_rested]], [[not_workDone], [rested]]).

triggers(rest,[[not_rested]]).

causes(rest, [[rested]]).

%%scenariusz

observation( [ [ not_rested ], [not_workDone] ], 0 ).

action( rest, 1 ).
action(work, 2).
