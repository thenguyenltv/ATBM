/--TAO AUDIT

------------------------------------RUN THESE COMMEND ABOVE AS SYS/XEPDB1 BEFORE RUN THIS FILE !!!!!-------------------------------
--ALTER SESSION SET CONTAINER=XEPDB1;
--alter session set "_ORACLE_SCRIPT"=true; 
--grant quyen audit cho OLS_TEST1
--grant execute on dbms_fga to ols_test1;
--grant audit_admin to ols_test1;
--grant audit_viewer to ols_test1;

--A)
begin
    dbms_fga.drop_policy
    (
        object_schema=>'OLS_TEST1',
        OBJECT_NAME=>'PHANCONG',
        POLICY_NAME=>'CAU_A'
    );
EXCEPTION
    WHEN OTHERS THEN
        IF SQLCODE != -28102 THEN
            RAISE;
        END IF;
END;
/
begin 
dbms_fga.add_policy
(
    object_schema=>'OLS_TEST1',
    OBJECT_NAME =>'PHANCONG',
    POLICY_NAME=>'CAU_A',
    AUDIT_COLUMN=>'THOIGIAN',
    --AUDIT_CONDITION=>'BAL >= 20000'
    STATEMENT_TYPES=>'UPDATE'
);
END;


/
--B)
begin
    dbms_fga.drop_policy
    (
        object_schema=>'OLS_TEST1',
        OBJECT_NAME=>'V_NHANVIEN',
        POLICY_NAME=>'CAU_B'
    );
EXCEPTION
    WHEN OTHERS THEN
        IF SQLCODE != -28102 THEN
            RAISE;
        END IF;
END;
/
begin 
dbms_fga.add_policy
(
    object_schema=>'OLS_TEST1',
    OBJECT_NAME =>'V_NHANVIEN',
    POLICY_NAME=>'CAU_B',
    AUDIT_COLUMN=>'LUONG,PHUCAP',
    AUDIT_CONDITION=> '''NV''||MANV!=USER',
    STATEMENT_TYPES=>'SELECT',
    AUDIT_COLUMN_OPTS=>DBMS_FGA.ANY_COLUMNS
);
END;
/
/
--C)
begin
    dbms_fga.drop_policy
    (
        object_schema=>'OLS_TEST1',
        OBJECT_NAME=>'V_NHANVIEN',
        POLICY_NAME=>'CAU_C'
    );
EXCEPTION
    WHEN OTHERS THEN
        IF SQLCODE != -28102 THEN
            RAISE;
        END IF;
END;
/
begin 
dbms_fga.add_policy
(
    object_schema=>'OLS_TEST1',
    OBJECT_NAME =>'V_NHANVIEN',
    POLICY_NAME=>'CAU_C',
    AUDIT_COLUMN=>'LUONG,PHUCAP',
    AUDIT_CONDITION=>'UPPER(F_VAITRO(USER)) != ''TAICHINH''',
    STATEMENT_TYPES=>'UPDATE',
    AUDIT_COLUMN_OPTS=>DBMS_FGA.ANY_COLUMNS
);
END;

/


SELECT * FROM UNIFIED_AUDIT_TRAIL WHERE AUDIT_TYPE='FineGrainedAudit';
        