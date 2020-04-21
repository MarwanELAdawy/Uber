--------------------------------------------------------
--  File created - Monday-April-20-2020   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Sequence DEPARTMENTS_SEQ
--------------------------------------------------------

   CREATE SEQUENCE  "DEPARTMENTS_SEQ"  MINVALUE 1 MAXVALUE 9990 INCREMENT BY 10 START WITH 280 NOCACHE  NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence EMPLOYEES_SEQ
--------------------------------------------------------

   CREATE SEQUENCE  "EMPLOYEES_SEQ"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 207 NOCACHE  NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence LOCATIONS_SEQ
--------------------------------------------------------

   CREATE SEQUENCE  "LOCATIONS_SEQ"  MINVALUE 1 MAXVALUE 9900 INCREMENT BY 100 START WITH 3300 NOCACHE  NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence TEST_SEQ
--------------------------------------------------------

   CREATE SEQUENCE  "TEST_SEQ"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 21 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Table CAR
--------------------------------------------------------

  CREATE TABLE "CAR" 
   (	"CAR_ID" VARCHAR2(20), 
	"COLOR" VARCHAR2(25), 
	"CAR_MODEL" VARCHAR2(20), 
	"DRIVER_PHONE" NUMBER(12,0)
   ) ;
--------------------------------------------------------
--  DDL for Table CITIES
--------------------------------------------------------

  CREATE TABLE "CITIES" 
   (	"NAME" VARCHAR2(20), 
	"BL7" NUMBER
   ) ;
--------------------------------------------------------
--  DDL for Table CLIENT
--------------------------------------------------------

  CREATE TABLE "CLIENT" 
   (	"PHONE" NUMBER(12,0), 
	"USER_NAME" VARCHAR2(25), 
	"LOCATION" VARCHAR2(25), 
	"MAIL" VARCHAR2(20), 
	"PASS" VARCHAR2(20)
   ) ;
--------------------------------------------------------
--  DDL for Table DRIVER
--------------------------------------------------------

  CREATE TABLE "DRIVER" 
   (	"PHONE" NUMBER(12,0), 
	"USER_NAME" VARCHAR2(25), 
	"RATE" NUMBER(2,0), 
	"MAIL" VARCHAR2(20), 
	"PASS" VARCHAR2(20)
   ) ;
--------------------------------------------------------
--  DDL for Table PAYEMENTACC
--------------------------------------------------------

  CREATE TABLE "PAYEMENTACC" 
   (	"C_NUM" NUMBER(20,0), 
	"C_PASS" VARCHAR2(25), 
	"PHONE" NUMBER(12,0)
   ) ;
--------------------------------------------------------
--  DDL for Table PAYMENT
--------------------------------------------------------

  CREATE TABLE "PAYMENT" 
   (	"P_ID" VARCHAR2(20), 
	"P_CLIENT" NUMBER(12,0), 
	"P_DRIVER" NUMBER(12,0)
   ) ;
--------------------------------------------------------
--  DDL for Table TRIP
--------------------------------------------------------

  CREATE TABLE "TRIP" 
   (	"TRIP_ID" VARCHAR2(20), 
	"TRIP_COST" NUMBER(20,0), 
	"START_LOC" VARCHAR2(20), 
	"END_LOC" VARCHAR2(20), 
	"C_PHONE" NUMBER(12,0), 
	"D_PHONE" NUMBER(12,0), 
	"RATE" NUMBER
   ) ;

---------------------------------------------------
--   DATA FOR TABLE CITIES
--   FILTER = none used
---------------------------------------------------
REM INSERTING into CITIES
Insert into CITIES (NAME,BL7) values ('shubra',1);
Insert into CITIES (NAME,BL7) values ('zamalek',2);
Insert into CITIES (NAME,BL7) values ('madinet nasr',3);
Insert into CITIES (NAME,BL7) values ('october',4);
Insert into CITIES (NAME,BL7) values ('mohandsen',5);
Insert into CITIES (NAME,BL7) values ('cairo',6);
Insert into CITIES (NAME,BL7) values ('madi',7);
Insert into CITIES (NAME,BL7) values ('mohandsin',8);

---------------------------------------------------
--   END DATA FOR TABLE CITIES
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE DRIVER
--   FILTER = none used
---------------------------------------------------
REM INSERTING into DRIVER
Insert into DRIVER (PHONE,USER_NAME,RATE,MAIL,PASS) values (230,'Marwan',51,'as@as.cc','120');
Insert into DRIVER (PHONE,USER_NAME,RATE,MAIL,PASS) values (1023,'moda',null,'asd@as.cc','1203');
Insert into DRIVER (PHONE,USER_NAME,RATE,MAIL,PASS) values (1000,'Marwan',5,'asd@as.cc','12345');

---------------------------------------------------
--   END DATA FOR TABLE DRIVER
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE CLIENT
--   FILTER = none used
---------------------------------------------------
REM INSERTING into CLIENT
Insert into CLIENT (PHONE,USER_NAME,LOCATION,MAIL,PASS) values (100,'Marwan','sdfsdfsd','marwan@m.cc','1230');

---------------------------------------------------
--   END DATA FOR TABLE CLIENT
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE TRIP
--   FILTER = none used
---------------------------------------------------
REM INSERTING into TRIP

---------------------------------------------------
--   END DATA FOR TABLE TRIP
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE CAR
--   FILTER = none used
---------------------------------------------------
REM INSERTING into CAR
Insert into CAR (CAR_ID,COLOR,CAR_MODEL,DRIVER_PHONE) values ('1011','blue','bmw',null);
Insert into CAR (CAR_ID,COLOR,CAR_MODEL,DRIVER_PHONE) values ('11','red','bmw',230);

---------------------------------------------------
--   END DATA FOR TABLE CAR
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE PAYEMENTACC
--   FILTER = none used
---------------------------------------------------
REM INSERTING into PAYEMENTACC

---------------------------------------------------
--   END DATA FOR TABLE PAYEMENTACC
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE PAYMENT
--   FILTER = none used
---------------------------------------------------
REM INSERTING into PAYMENT

---------------------------------------------------
--   END DATA FOR TABLE PAYMENT
---------------------------------------------------
--------------------------------------------------------
--  Constraints for Table CAR
--------------------------------------------------------

  ALTER TABLE "CAR" MODIFY ("CAR_ID" NOT NULL ENABLE);
 
  ALTER TABLE "CAR" ADD PRIMARY KEY ("CAR_ID") ENABLE;
--------------------------------------------------------
--  Constraints for Table CITIES
--------------------------------------------------------

  ALTER TABLE "CITIES" ADD CONSTRAINT "CITIES_PK" PRIMARY KEY ("NAME") ENABLE;
 
  ALTER TABLE "CITIES" MODIFY ("NAME" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table CLIENT
--------------------------------------------------------

  ALTER TABLE "CLIENT" MODIFY ("PHONE" NOT NULL ENABLE);
 
  ALTER TABLE "CLIENT" ADD PRIMARY KEY ("PHONE") ENABLE;
--------------------------------------------------------
--  Constraints for Table DRIVER
--------------------------------------------------------

  ALTER TABLE "DRIVER" MODIFY ("PHONE" NOT NULL ENABLE);
 
  ALTER TABLE "DRIVER" ADD PRIMARY KEY ("PHONE") ENABLE;
--------------------------------------------------------
--  Constraints for Table PAYEMENTACC
--------------------------------------------------------

  ALTER TABLE "PAYEMENTACC" MODIFY ("C_NUM" NOT NULL ENABLE);
 
  ALTER TABLE "PAYEMENTACC" ADD PRIMARY KEY ("C_NUM") ENABLE;
--------------------------------------------------------
--  Constraints for Table PAYMENT
--------------------------------------------------------

  ALTER TABLE "PAYMENT" ADD CONSTRAINT "PAYPAL_PK" PRIMARY KEY ("P_ID") ENABLE;
 
  ALTER TABLE "PAYMENT" MODIFY ("P_ID" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table TRIP
--------------------------------------------------------

  ALTER TABLE "TRIP" MODIFY ("TRIP_ID" NOT NULL ENABLE);
 
  ALTER TABLE "TRIP" ADD PRIMARY KEY ("TRIP_ID") ENABLE;
--------------------------------------------------------
--  DDL for Index CITIES_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "CITIES_PK" ON "CITIES" ("NAME") 
  ;
--------------------------------------------------------
--  DDL for Index PAYPAL_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "PAYPAL_PK" ON "PAYMENT" ("P_ID") 
  ;
--------------------------------------------------------
--  Ref Constraints for Table CAR
--------------------------------------------------------

  ALTER TABLE "CAR" ADD CONSTRAINT "CAR_DRIVER_FK1" FOREIGN KEY ("DRIVER_PHONE")
	  REFERENCES "DRIVER" ("PHONE") ENABLE;



--------------------------------------------------------
--  Ref Constraints for Table PAYEMENTACC
--------------------------------------------------------

  ALTER TABLE "PAYEMENTACC" ADD CONSTRAINT "CL_PHONE" FOREIGN KEY ("PHONE")
	  REFERENCES "CLIENT" ("PHONE") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table PAYMENT
--------------------------------------------------------

  ALTER TABLE "PAYMENT" ADD CONSTRAINT "PAYPAL_CLIENT_FK1" FOREIGN KEY ("P_CLIENT")
	  REFERENCES "CLIENT" ("PHONE") ENABLE;
 
  ALTER TABLE "PAYMENT" ADD CONSTRAINT "PAYPAL_DRIVER_FK1" FOREIGN KEY ("P_DRIVER")
	  REFERENCES "DRIVER" ("PHONE") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table TRIP
--------------------------------------------------------

  ALTER TABLE "TRIP" ADD CONSTRAINT "TRIP_CLIENT_FK1" FOREIGN KEY ("C_PHONE")
	  REFERENCES "CLIENT" ("PHONE") ENABLE;
 
  ALTER TABLE "TRIP" ADD CONSTRAINT "TRIP_DRIVER_FK1" FOREIGN KEY ("D_PHONE")
	  REFERENCES "DRIVER" ("PHONE") ENABLE;
--------------------------------------------------------
--  DDL for View EMP_DETAILS_VIEW
--------------------------------------------------------

  CREATE OR REPLACE VIEW "EMP_DETAILS_VIEW" ("EMPLOYEE_ID", "JOB_ID", "MANAGER_ID", "DEPARTMENT_ID", "LOCATION_ID", "COUNTRY_ID", "FIRST_NAME", "LAST_NAME", "SALARY", "COMMISSION_PCT", "DEPARTMENT_NAME", "JOB_TITLE", "CITY", "STATE_PROVINCE", "COUNTRY_NAME", "REGION_NAME") AS 
  SELECT
  e.employee_id,
  e.job_id,
  e.manager_id,
  e.department_id,
  d.location_id,
  l.country_id,
  e.first_name,
  e.last_name,
  e.salary,
  e.commission_pct,
  d.department_name,
  j.job_title,
  l.city,
  l.state_province,
  c.country_name,
  r.region_name
FROM
  employees e,
  departments d,
  jobs j,
  locations l,
  countries c,
  regions r
WHERE e.department_id = d.department_id
  AND d.location_id = l.location_id
  AND l.country_id = c.country_id
  AND c.region_id = r.region_id
  AND j.job_id = e.job_id
WITH READ ONLY;
--------------------------------------------------------
--  DDL for Function ALLCITIES
--------------------------------------------------------

  CREATE OR REPLACE FUNCTION "ALLCITIES" 
RETURN sys_refcursor
is
cities sys_refcursor;
begin
open cities for
select PHONE from driver ;
return cities;
end;

/

--------------------------------------------------------
--  DDL for Procedure DELETE_DRIVER
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "DELETE_DRIVER" 
  (driver_phone VARCHAR2)
as
begin
	Delete from driver 
	where phone= driver_phone;
end;

/

--------------------------------------------------------
--  DDL for Procedure GETALLRATE
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "GETALLRATE" 
(sumRate OUT NUMBER,dPhone NUMBER)
as
begin
select sum (rate)
into
sumrate
from trip 
where D_PHONE = dphone;
end;

/

--------------------------------------------------------
--  DDL for Procedure INSERT_DRIVER
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "INSERT_DRIVER" 
(phone number, UN VARCHAR2,
mail  VARCHAR2, pass  VARCHAR2)
as
begin
insert  into  driver
(phone, USER_NAME,mail, pass)
Values ( phone, UN, mail, pass) ;

End;

/

--------------------------------------------------------
--  DDL for Procedure UPDATE_CAR
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "UPDATE_CAR" 
  (cn VARCHAR2,cc VARCHAR2,cm VARCHAR2)
as
begin
	update  car 
	set   CAR_ID = cn, COLOR=cc, CAR_MODEL = cm
	where car_id=cn;
end;

/

--------------------------------------------------------
--  DDL for Procedure UPDATE_DRIVER
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "UPDATE_DRIVER" 
  (phone number, UN VARCHAR2,mail  VARCHAR2, pass  VARCHAR2)
as
begin
	update  driver 
	set   phone  =   phone, user_name=UN, mail = mail, pass=pass
	where   phone  =   phone ;
end;

/

--------------------------------------------------------
--  DDL for Procedure UPDATE_DRIVERRATE
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "UPDATE_DRIVERRATE" 
(ratevalue NUMBER,phonedriver NUMBER)
as
begin
UPDATE  driver 
set 
RATE = ratevalue
where phone = phonedriver;
End ;

/

--------------------------------------------------------
--  DDL for Procedure UPDATE_RATE
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "UPDATE_RATE" 
(RID NUMBER,tripid number)
as
begin
update    trip 
	set   RATE  =   RID
	where   TRIP_ID  =   TripID  ;
End ;

/

