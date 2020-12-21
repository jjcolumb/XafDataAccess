;#DropDB XafDataAccessEasyTest

#Application XafDataAccessWin
#Application XafDataAccessWeb

*FillForm
 User Name = Admin
*Action Log In

#IfDef XafDataAccessWin

*Action About...
 
*Action OK

#EndIf

#IfDef XafDataAccessWeb
*Action Navigation(My Details)
#EndIf
