;#DropDB XAFDemoTwoEasyTest

#Application XAFDemoTwoWin
;#Application XAFDemoTwoWeb
#IfDef XAFDemoTwoWin

*Action About...
 
*Action OK

#EndIf

#IfDef XAFDemoTwoWeb
!Action Navigation(My Details)
#EndIf
