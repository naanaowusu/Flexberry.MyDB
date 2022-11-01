﻿




CREATE TABLE ClassMeeting (
 primaryKey UUID NOT NULL,
 MeetingDate TIMESTAMP(3) NULL,
 PRIMARY KEY (primaryKey));


CREATE TABLE Speaker (
 primaryKey UUID NOT NULL,
 FirstName VARCHAR(255) NULL,
 LastName VARCHAR(255) NULL,
 PRIMARY KEY (primaryKey));


CREATE TABLE Book (
 primaryKey UUID NOT NULL,
 Name VARCHAR(255) NULL,
 Author VARCHAR(255) NULL,
 PagesCount INT NULL,
 CoverURL VARCHAR(255) NULL,
 DescriptionURL VARCHAR(255) NULL,
 Tags VARCHAR(255) NULL,
 PRIMARY KEY (primaryKey));


CREATE TABLE Presntation (
 primaryKey UUID NOT NULL,
 BookScore INT NULL,
 PresentationURL VARCHAR(255) NULL,
 VideoURL VARCHAR(255) NULL,
 BookReview VARCHAR(255) NULL,
 Book_m0 UUID NOT NULL,
 Speaker_m0 UUID NOT NULL,
 ClassMeeting_m0 UUID NOT NULL,
 PRIMARY KEY (primaryKey));


CREATE TABLE STORMNETLOCKDATA (
 LockKey VARCHAR(300) NOT NULL,
 UserName VARCHAR(300) NOT NULL,
 LockDate TIMESTAMP(3) NULL,
 PRIMARY KEY (LockKey));


CREATE TABLE STORMSETTINGS (
 primaryKey UUID NOT NULL,
 Module VARCHAR(1000) NULL,
 Name VARCHAR(255) NULL,
 Value TEXT NULL,
 "User" VARCHAR(255) NULL,
 PRIMARY KEY (primaryKey));


CREATE TABLE STORMAdvLimit (
 primaryKey UUID NOT NULL,
 "User" VARCHAR(255) NULL,
 Published BOOLEAN NULL,
 Module VARCHAR(255) NULL,
 Name VARCHAR(255) NULL,
 Value TEXT NULL,
 HotKeyData INT NULL,
 PRIMARY KEY (primaryKey));


CREATE TABLE STORMFILTERSETTING (
 primaryKey UUID NOT NULL,
 Name VARCHAR(255) NOT NULL,
 DataObjectView VARCHAR(255) NOT NULL,
 PRIMARY KEY (primaryKey));


CREATE TABLE STORMWEBSEARCH (
 primaryKey UUID NOT NULL,
 Name VARCHAR(255) NOT NULL,
 "Order" INT NOT NULL,
 PresentView VARCHAR(255) NOT NULL,
 DetailedView VARCHAR(255) NOT NULL,
 FilterSetting_m0 UUID NOT NULL,
 PRIMARY KEY (primaryKey));


CREATE TABLE STORMFILTERDETAIL (
 primaryKey UUID NOT NULL,
 Caption VARCHAR(255) NOT NULL,
 DataObjectView VARCHAR(255) NOT NULL,
 ConnectMasterProp VARCHAR(255) NOT NULL,
 OwnerConnectProp VARCHAR(255) NULL,
 FilterSetting_m0 UUID NOT NULL,
 PRIMARY KEY (primaryKey));


CREATE TABLE STORMFILTERLOOKUP (
 primaryKey UUID NOT NULL,
 DataObjectType VARCHAR(255) NOT NULL,
 Container VARCHAR(255) NULL,
 ContainerTag VARCHAR(255) NULL,
 FieldsToView VARCHAR(255) NULL,
 FilterSetting_m0 UUID NOT NULL,
 PRIMARY KEY (primaryKey));


CREATE TABLE UserSetting (
 primaryKey UUID NOT NULL,
 AppName VARCHAR(256) NULL,
 UserName VARCHAR(512) NULL,
 UserGuid UUID NULL,
 ModuleName VARCHAR(1024) NULL,
 ModuleGuid UUID NULL,
 SettName VARCHAR(256) NULL,
 SettGuid UUID NULL,
 SettLastAccessTime TIMESTAMP(3) NULL,
 StrVal VARCHAR(256) NULL,
 TxtVal TEXT NULL,
 IntVal INT NULL,
 BoolVal BOOLEAN NULL,
 GuidVal UUID NULL,
 DecimalVal DECIMAL(20,10) NULL,
 DateTimeVal TIMESTAMP(3) NULL,
 PRIMARY KEY (primaryKey));


CREATE TABLE ApplicationLog (
 primaryKey UUID NOT NULL,
 Category VARCHAR(64) NULL,
 EventId INT NULL,
 Priority INT NULL,
 Severity VARCHAR(32) NULL,
 Title VARCHAR(256) NULL,
 Timestamp TIMESTAMP(3) NULL,
 MachineName VARCHAR(32) NULL,
 AppDomainName VARCHAR(512) NULL,
 ProcessId VARCHAR(256) NULL,
 ProcessName VARCHAR(512) NULL,
 ThreadName VARCHAR(512) NULL,
 Win32ThreadId VARCHAR(128) NULL,
 Message VARCHAR(2500) NULL,
 FormattedMessage TEXT NULL,
 PRIMARY KEY (primaryKey));



 ALTER TABLE Presntation ADD CONSTRAINT FK80050840eaacae281c15f276593367c0b5045eb3 FOREIGN KEY (Book_m0) REFERENCES Book; 
CREATE INDEX Index80050840eaacae281c15f276593367c0b5045eb3 on Presntation (Book_m0); 

 ALTER TABLE Presntation ADD CONSTRAINT FK6b054e2e9d2b63d2d5be1c2cc429aa336abf847b FOREIGN KEY (Speaker_m0) REFERENCES Speaker; 
CREATE INDEX Index6b054e2e9d2b63d2d5be1c2cc429aa336abf847b on Presntation (Speaker_m0); 

 ALTER TABLE Presntation ADD CONSTRAINT FK3edf6a7bde2adf23961884089f03f6eb56c6d0e2 FOREIGN KEY (ClassMeeting_m0) REFERENCES ClassMeeting; 
CREATE INDEX Index3edf6a7bde2adf23961884089f03f6eb56c6d0e2 on Presntation (ClassMeeting_m0); 

 ALTER TABLE STORMWEBSEARCH ADD CONSTRAINT FKc4378e39870eb056aec84088683297a01d2a6200 FOREIGN KEY (FilterSetting_m0) REFERENCES STORMFILTERSETTING; 

 ALTER TABLE STORMFILTERDETAIL ADD CONSTRAINT FK921d16269835017e2a0d0e29ad6fb175454a70d0 FOREIGN KEY (FilterSetting_m0) REFERENCES STORMFILTERSETTING; 

 ALTER TABLE STORMFILTERLOOKUP ADD CONSTRAINT FKce38ef0db3f01a53acaa49fed8853fb941ad47ba FOREIGN KEY (FilterSetting_m0) REFERENCES STORMFILTERSETTING; 

