# Reprezentacja wiedzy - translacja na Prologa

## 1. Formuły
Formuły logiczne występujące w zdaniach $\alpha$ oraz $\pi$ muszą być sprowadzone do koniunkcyjnej postacji normalnej, tzn. są zapisywane jako koniunkcja alternatyw. Wtedy mogą być reprezentowane w Prologu jako tablica tablic. Przykładowo:

$\alpha = (a \lor \lnot b) \land (\lnot c \lor d)$

`[[a, not_b], [not_c, d]]`

## 2. Zdania

1. $A \text{ causes } \alpha \text{ if } \pi$  
   `causes(Action, Results, Conditions).`

2. $A \text{ typically causes } \alpha \text{ if } \pi$  
   `typically_causes(Action, TypicalResults, Conditions).`

3. $A \text{ invokes } B \text{ after } d \text{ if } \pi$  
   `invokes(Action, ResultAction, Delay, Conditions).`

4. $\pi \text{ triggers } A$  
   `triggers(Conditions, Action).`

5. $A \text{ releases } f \text{ if } \pi$  
   `releases(Action, Fluent, Conditions).`

6. $\text{ disable } A \text{ between } d_1, d_2$  
   `disable_between(Action, Start, End).`

7. $\text{ disable } A \text{ when } d$  
   `disable_when(Action, Moment).`