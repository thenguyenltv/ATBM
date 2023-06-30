---------------------------- RUN AS SYS THESE COMMEND BEFORE RUN FILE !!!!!---------------------------------
--ALTER SESSION SET CONTAINER=XEPDB1;
--alter session set "_ORACLE_SCRIPT"=true;

set serveroutput on size unlimited;
/
create or replace procedure user_list
as
    cursor cur is (select username from dba_users);
    str varchar(1000);
    usr cur%rowtype;
begin
    dbms_output.put_line('username');
    open cur;
    loop
    fetch cur into usr;
        exit when cur%notfound;
        dbms_output.put_line(usr.username);
    end loop;
    close cur;
end;
/
create or replace procedure priv_info
as
    cursor cur is (select grantee,privilege from dba_sys_privs);
    str varchar(1000);
    usr cur%rowtype;
begin
    dbms_output.put_line('grantee'||chr(9)||chr(9)||'privilege');
    open cur;
    loop
    fetch cur into usr;
        exit when cur%notfound;
        dbms_output.put_line(usr.grantee||chr(9)||chr(9)||usr.privilege);
    end loop;
    close cur;
end;

/
create or replace procedure implement_usr(priv varchar2, usrname varchar2, pass in varchar2 default null)
as
    str varchar(1000);
begin
--    str := 'alter session set "_ORACLE_SCRIPT"=true';
--    execute immediate(str);
    if priv='drop' then
        str:=priv||' user '||usrname||' cascade';
        execute immediate(str);
    else
        str:=priv||' user '||usrname||' identified by '||pass;
        execute immediate(str);
        str:='grant create session to '||usrname;
        execute immediate(str);
    end if;
    
--    str := 'alter session set "_ORACLE_SCRIPT"=false';
--    execute immediate(str);
end;
/

/
create or replace procedure implement_role(priv varchar2, rolename varchar2, pass varchar2)
as
    str varchar(1000);
begin
--    str := 'alter session set "_ORACLE_SCRIPT"=true';
--    execute immediate(str);
    if priv='drop' then
        str:='drop role '||rolename;
    elsif pass=' ' then
        str:=priv||' role '||rolename;
    else
        str:=priv||' role '||rolename||' identified by '||pass;
    end if;
    execute immediate(str);
--    str := 'alter session set "_ORACLE_SCRIPT"=false';
--    execute immediate(str);
end;
/
execute implement_role('create','bacsi','123');
create or replace procedure usp_grant (priv varchar2, usrname varchar2,opt in varchar2 default null,tab in varchar2 default null)
as
    str varchar(1000);
begin
--    str := 'alter session set "_ORACLE_SCRIPT"=true';
--    execute immediate(str);
    if tab is not null then
        str:= 'grant '||priv||' on '||tab||' to '||usrname||' '||opt;
    else
        str:='grant '||priv||' to '||usrname||opt;
    end if;
    execute immediate(str);
--    str := 'alter session set "_ORACLE_SCRIPT"=false';
--    execute immediate(str);
end;

/
create or replace procedure grant_role_2_usr (rolename varchar2,usrname varchar2)
as
    str varchar(1000);
begin
--    str := 'alter session set "_ORACLE_SCRIPT"=true';
--    execute immediate(str);
    str:='grant '||rolename||' to '||usrname;
    execute immediate(str);
--    str := 'alter session set "_ORACLE_SCRIPT"=false';
--    execute immediate(str);
end;


/
create or replace procedure usp_revoke (priv varchar2, usrname varchar2,tab in varchar2)
as
    str varchar(1000);
begin
--    str := 'alter session set "_ORACLE_SCRIPT"=true';
--    execute immediate(str);
    str:= 'revoke '||priv||' on '||tab||' from '||usrname;
    execute immediate(str);
--    str := 'alter session set "_ORACLE_SCRIPT"=false';
--    execute immediate(str);
end;

/

create or replace procedure revoke_role_from_usr (rolename varchar2,usrname varchar2)
as
    str varchar(1000);
begin
--    str := 'alter session set "_ORACLE_SCRIPT"=true';
--    execute immediate(str);
    str:= 'revoke '||rolename||' from '||usrname;
    execute immediate(str);
--    str := 'alter session set "_ORACLE_SCRIPT"=false';
--    execute immediate(str);
end;

/

create or replace procedure priv_info_of_usr (usrname varchar2)
as
    cursor cur is (select grantee,table_name,privilege from dba_tab_privs where grantee=usrname);
    str varchar(1000);
    usr cur%rowtype;
begin
    dbms_output.put_line('grantee'||chr(9)||'table_name'||chr(9)||'privilege');
    open cur;
    loop
    fetch cur into usr;
        exit when cur%notfound;
        dbms_output.put_line(usr.grantee||chr(9)||usr.table_name||chr(9)||usr.privilege);
    end loop;
    close cur;
end;



/
execute user_list();
execute priv_info();
EXECUTE implement_usr('create','test','123')
show user

SELECT * FROM SESSION_PRIVS;
select * from dba_sys_privs;


