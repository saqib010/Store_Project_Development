/* proc*/ 
/*Login*/

create Procedure Checklogin

@name varchar(30),
@pass varchar(30)
 As  
Begin  
Declare @Exist int  
IF exists( Select * From tb_login as l Where l.username=@name and l.password=@pass)  
  
Begin  
       Set @Exist = 1   
End  
   
Else  
   
Begin  
       Set @Exist=0  
end  
   
Return @Exist  
   
end  

declare @outi int
exec @outi = Checklogin 'test1','test'
select @outi