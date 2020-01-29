/* proc*/ 
/*Login*/

create Procedure Checklogin

@name varchar(30),
@pass varchar(30)
 As  
Begin  
IF exists( Select * From tb_login as l Where l.username=@name and l.password=@pass)  
  
Begin  
       select 1 
End  
   
Else  
   
Begin  
       select 0 
end   
   
end  


/*//////////////////
**/
create Procedure updatePassword

@name varchar(30),
@pass varchar(30),
@newpass varchar(30)
 As  
Begin  
IF exists( Select * From tb_login as l Where l.username=@name and l.password=@pass)  
  
Begin  
       UPDATE tb_login
	SET password = @newpass
	WHERE username = @name
	and password = @pass;
	select 1
End  
   
Else  
   
Begin  
       select 0 
end   
   
end  

exec  updatePassword 'aaa','test','test2'
select * from tb_login