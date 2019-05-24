%% plik testowy z reprezetnacją przykładu

typicallyCauses(work, [[workDone]], [[\+ workDone], [rested]]).

causes(work, [[\+ rested]], [[\+ workDone], [rested]]).

triggers(rest,[[\+ rested]]).

causes(rest, [[rested]]).