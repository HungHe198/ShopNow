CREATE DATABASE PRO131_EF
GO
USE PRO131_EF
GO
CREATE TABLE [USERS] (
  [ID] UNIQUEIDENTIFIER NOT NULL DEFAULT newsequentialid(),
  [USERNAME] VARCHAR(255) NOT NULL,
  [EMAIL] VARCHAR(255) NOT NULL,
  [PASSWORD] VARCHAR(255) NOT NULL,
  [PHONE_NUMBER] VARCHAR(255) NULL,
  [ADDRESS] VARCHAR(255) NULL,
  
  [CREATED_TIME] DATETIME NULL,
  [CREATED_BY] UNIQUEIDENTIFIER NULL,
  
  [DELETED] BIT NOT NULL,
  [DELETED_TIME] DATETIME NULL,
  [DELETED_BY] UNIQUEIDENTIFIER NULL,
  
  [MODIFIED_TIME] DATETIME NULL,
  [MODIFIED_BY] UNIQUEIDENTIFIER NULL,

  [STATUS] TINYINT NULL,

  [ROLE_ID] UNIQUEIDENTIFIER NULL,
  PRIMARY KEY ([ID]),
);

CREATE TABLE [PRODUCTS] (
  [ID] UNIQUEIDENTIFIER NOT NULL DEFAULT newsequentialid(),
  [PRODUCT_NAME] VARCHAR(255) NOT NULL,

  [DISCOUNT_ID] UNIQUEIDENTIFIER NOT NULL,

  [PRICE] DECIMAL NULL,
  [DESCRIPTION] VARCHAR(255) NULL,
  [QUANTITY] INT NULL,
  [WARRANTY] FLOAT NULL,
  [DISPLAY] FLOAT NOT NULL,
  [RAM] INT NOT NULL,
  [ROM] INT NOT NULL,

  [CREATED_TIME] DATETIME NULL,
  [CREATED_BY] UNIQUEIDENTIFIER NULL,

  [DELETED] BIT NOT NULL DEFAULT 1,
  [DELETED_TIME] DATETIME NULL,
  [DELETED_BY] UNIQUEIDENTIFIER NULL,

  [MODIFIED_TIME] DATETIME NULL,
  [MODIFIED_BY] UNIQUEIDENTIFIER NULL,

  [STATUS] TINYINT NULL DEFAULT 1,
  PRIMARY KEY ([ID]),
  --FOREIGN KEY ([DISCOUNT_ID]) REFERENCES [DISCOUNTS] ([ID]),
  --FOREIGN KEY ([PRODUCT_CATEGORY]) REFERENCES [PRODUCT_CATEGORIES] ([ID]),
  --FOREIGN KEY ([BRAND]) REFERENCES [BRANDS] ([ID])
);

CREATE TABLE [PRODUCT_DETAIL] 
(
	[ID] UNIQUEIDENTIFIER NOT NULL DEFAULT NEWSEQUENTIALID(),

	[PRODUCT_ID] UNIQUEIDENTIFIER NOT NULL,
	
	[CODE] VARCHAR(255) NOT NULL,
	[RAM] INT NOT NULL,
	[DISPLAY] FLOAT NOT NULL,
	[CHIP] VARCHAR(255) NOT NULL,
	[CAMERA] VARCHAR(255) NULL,
	[MEMORY] VARCHAR(255) NULL,
	[PIN] FLOAT NOT NULL,
	[COLOR] VARCHAR(100) NOT NULL,
	[URL_IMAGE] VARCHAR(255) NOT NULL,
	[OPERATING_SYSTEM]	VARCHAR(255) NULL,
	
	[CREATED_TIME] DATETIME NULL,
	[CREATED_BY] UNIQUEIDENTIFIER NULL,

	[DELETED] BIT NOT NULL DEFAULT 1,
	[DELETED_TIME] DATETIME NULL,
	[DELETED_BY] UNIQUEIDENTIFIER NULL,

	[MODIFIED_TIME] DATETIME NULL,
	[MODIFIED_BY] UNIQUEIDENTIFIER NULL,
	
	PRIMARY KEY ([ID]),
);

CREATE TABLE [BILL] 
(
	[ID] UNIQUEIDENTIFIER NOT NULL DEFAULT NEWSEQUENTIALID(),
	
	[CUSTOMER_ID] UNIQUEIDENTIFIER NOT NULL,
	[STATUS] TINYINT NOT NULL DEFAULT 1,
	[TOTAL_PRICE] DECIMAL NOT NULL , 
	
	[CREATED_TIME] DATETIME NULL,
	[CREATED_BY] UNIQUEIDENTIFIER NULL,

	[DELETED] BIT NOT NULL DEFAULT 1,
	[DELETED_TIME] DATETIME NULL,
	[DELETED_BY] UNIQUEIDENTIFIER NULL,

	[MODIFIED_TIME] DATETIME NULL,
	[MODIFIED_BY] UNIQUEIDENTIFIER NULL,
	
	PRIMARY KEY ([ID]),
);

CREATE TABLE [BILL_DETAIL]
(
	[ID] UNIQUEIDENTIFIER NOT NULL DEFAULT NEWSEQUENTIALID(),
	
	[PRODUCT_ID] UNIQUEIDENTIFIER NOT NULL,
	[BILL_ID] UNIQUEIDENTIFIER NOT NULL,
	[QUANTITY] INT NOT NULL,
	[PRICE] DECIMAL NOT NULL,

	
);
CREATE TABLE [CART]
(
	[ID] UNIQUEIDENTIFIER NOT NULL DEFAULT NEWSEQUENTIALID(),
	
	[USER_ID] UNIQUEIDENTIFIER NOT NULL,
	
	PRIMARY KEY (ID),
);
CREATE TABLE [CART_PRODUCT]
(
	[CART_ID] UNIQUEIDENTIFIER NOT NULL,
	[PRODUCT_ID] UNIQUEIDENTIFIER NOT NULL,
	[QUANTITY] FLOAT NOT NULL,
	PRIMARY KEY (CART_ID, PRODUCT_ID),
);
CREATE TABLE [CUSTOMER]
(
	[ID] UNIQUEIDENTIFIER NOT NULL DEFAULT NEWSEQUENTIALID(),
	
	[CUSTOMER_TYPE_ID] UNIQUEIDENTIFIER NOT NULL,
	[USER_ID] UNIQUEIDENTIFIER NOT NULL,
	[NAME] NVARCHAR(255) NOT NULL,
	[PHONE_NUMBER] TEXT NOT NULL,
	[EMAIL] VARCHAR(255) NULL,
	[ADDRESS] NVARCHAR(255) NOT NULL,
	[POINT] INT NULL DEFAULT 0,

	PRIMARY KEY(ID)

);
CREATE TABLE [CUSTOMER_TYPE]
(
	[ID] UNIQUEIDENTIFIER NOT NULL DEFAULT NEWSEQUENTIALID(),
	[NAME] NVARCHAR(255) NULL,
	[DESCRIPTION] NVARCHAR(255) NULL,
	PRIMARY KEY(ID)

);
CREATE TABLE [FACILITY]
(
	[ID] UNIQUEIDENTIFIER NOT NULL DEFAULT NEWSEQUENTIALID(),
	[NAME] NVARCHAR(255) NOT NULL,
	[PHONE_NUMBER] TEXT NOT NULL,
	[EMAIL] NVARCHAR(255) NOT NULL,
	[ADDRESS] NVARCHAR(255) NOT NULL,
	
	[CREATED_TIME] DATETIME NULL,
    [CREATED_BY] UNIQUEIDENTIFIER NULL,
    
    [DELETED] BIT NOT NULL,
    [DELETED_TIME] DATETIME NULL,
    [DELETED_BY] UNIQUEIDENTIFIER NULL,
    
    [MODIFIED_TIME] DATETIME NULL,
    [MODIFIED_BY] UNIQUEIDENTIFIER NULL,
    
    [STATUS] TINYINT NULL,

	PRIMARY KEY(ID)


);
CREATE TABLE [SUPPLIER] 
(
	[ID] UNIQUEIDENTIFIER NOT NULL DEFAULT NEWSEQUENTIALID(),
	[EMPLOYEE_ID] UNIQUEIDENTIFIER NOT NULL,
	[NAME] NVARCHAR(255) NOT NULL,
	[PHONE_NUMBER] TEXT NOT NULL,
	[EMAIL] NVARCHAR(255) NOT NULL,
	[ADDRESS] NVARCHAR(255) NOT NULL,
	
	[CREATED_TIME] DATETIME NULL,
    [CREATED_BY] UNIQUEIDENTIFIER NULL,
    
    [DELETED] BIT NOT NULL,
    [DELETED_TIME] DATETIME NULL,
    [DELETED_BY] UNIQUEIDENTIFIER NULL,
    
    [MODIFIED_TIME] DATETIME NULL,
    [MODIFIED_BY] UNIQUEIDENTIFIER NULL,
    
    [STATUS] TINYINT NULL,

	PRIMARY KEY(ID)

);

CREATE TABLE [IMPORT_HISTORY]
(
	[ID] UNIQUEIDENTIFIER NOT NULL DEFAULT NEWSEQUENTIALID(),
	[PRODUCT_ID] UNIQUEIDENTIFIER NOT NULL,
	[SUPPLIER_ID] UNIQUEIDENTIFIER NOT NULL,
	[PRODUCT_NAME] NVARCHAR(255) NOT NULL,
	[QUANTITY] INT NULL DEFAULT 0,
	[PRICE] DECIMAL NULL DEFAULT 0,
	
	[CREATED_TIME] DATETIME NULL,
    [CREATED_BY] UNIQUEIDENTIFIER NULL,
    
    [DELETED] BIT NOT NULL,
    [DELETED_TIME] DATETIME NULL,
    [DELETED_BY] UNIQUEIDENTIFIER NULL,
    
    [MODIFIED_TIME] DATETIME NULL,
    [MODIFIED_BY] UNIQUEIDENTIFIER NULL,
    
    [STATUS] TINYINT NULL,

	PRIMARY KEY(ID)


);
CREATE TABLE [EMPLOYEE]
(
	[ID] UNIQUEIDENTIFIER NOT NULL DEFAULT NEWSEQUENTIALID(),
	[FACILITY_ID] UNIQUEIDENTIFIER NOT NULL,
	[USER_ID] UNIQUEIDENTIFIER NOT NULL,
	[NAME] NVARCHAR(255) NOT NULL,
	[PHONE_NUMBER] TEXT NULL,
	[EMAIL] VARCHAR(255) NULL,
	[ADDRESS] NVARCHAR(255) NULL,


	[CREATED_TIME] DATETIME NULL,
    [CREATED_BY] UNIQUEIDENTIFIER NULL,
    
    [DELETED] BIT NOT NULL,
    [DELETED_TIME] DATETIME NULL,
    [DELETED_BY] UNIQUEIDENTIFIER NULL,
    
    [MODIFIED_TIME] DATETIME NULL,
    [MODIFIED_BY] UNIQUEIDENTIFIER NULL,
    
    [STATUS] TINYINT NULL,

	PRIMARY KEY(ID)


);
CREATE TABLE [ROLES]
(
	[ID] UNIQUEIDENTIFIER NOT NULL DEFAULT NEWSEQUENTIALID(),
	[NAME] NVARCHAR(255) NULL,
	[DESCRIPTION] NVARCHAR(255) NULL,
	PRIMARY KEY (ID)
);
CREATE TABLE [DISCOUNT] 
(
	
	[ID] UNIQUEIDENTIFIER NOT NULL DEFAULT NEWSEQUENTIALID(),
	[NAME] NVARCHAR(255) NULL,
	[DISCOUNT] INT NOT NULL,
	[DESCRIPTION] NVARCHAR(255) NULL,

	

	[CREATED_TIME] DATETIME NULL,
    [CREATED_BY] UNIQUEIDENTIFIER NULL,
    
    [DELETED] BIT NOT NULL,
    [DELETED_TIME] DATETIME NULL,
    [DELETED_BY] UNIQUEIDENTIFIER NULL,
    
    [MODIFIED_TIME] DATETIME NULL,
    [MODIFIED_BY] UNIQUEIDENTIFIER NULL,
    
    [STATUS] TINYINT NULL,

	PRIMARY KEY (ID)
);
-- PRODUCTS
ALTER TABLE PRODUCTS
ADD CONSTRAINT FK_PRODUCTS_DISCOUNT_ID 
FOREIGN KEY ([DISCOUNT_ID])
REFERENCES DISCOUNT(ID)
ON UPDATE CASCADE;
--PRODUCT DETAIL
ALTER TABLE [PRODUCT_DETAIL]
ADD CONSTRAINT FK_PD_PRODUCTS_ID 
FOREIGN KEY ([PRODUCT_ID])
REFERENCES PRODUCTS(ID)
ON UPDATE CASCADE;
--BILL
ALTER TABLE [BILL]
ADD CONSTRAINT FK_BILL_CUSTOMER_ID 
FOREIGN KEY ([CUSTOMER_ID])
REFERENCES CUSTOMER(ID)
ON UPDATE CASCADE;
--BILL DETAIL
ALTER TABLE [BILL_DETAIL]
ADD CONSTRAINT FK_BD_PRODUCTS_ID 
FOREIGN KEY ([PRODUCT_ID])
REFERENCES PRODUCTS(ID)
ON UPDATE CASCADE;
-----------------------
ALTER TABLE [BILL_DETAIL]
ADD CONSTRAINT FK_BD_BILL_ID 
FOREIGN KEY ([BILL_ID])
REFERENCES BILL(ID)
ON UPDATE CASCADE;
--CART
ALTER TABLE [CART]
ADD CONSTRAINT FK_CART_USER_ID 
FOREIGN KEY ([USER_ID])
REFERENCES [USERS](ID)
ON UPDATE CASCADE;
--CART_PRODUCT
ALTER TABLE [CART_PRODUCT]
ADD CONSTRAINT FK_PK1_ID 
FOREIGN KEY ([CART_ID])
REFERENCES [CART](ID)
ON UPDATE CASCADE;
-------------------------
ALTER TABLE [CART_PRODUCT]
ADD CONSTRAINT FK_PK2_ID 
FOREIGN KEY ([PRODUCT_ID])
REFERENCES [PRODUCTS](ID)
ON UPDATE CASCADE;
--CUSTOMER
ALTER TABLE [CUSTOMER]
ADD CONSTRAINT FK_CUSTOMER_USER_ID 
FOREIGN KEY ([USER_ID])
REFERENCES [USERS](ID)
ON UPDATE CASCADE;
---------------------------------------
ALTER TABLE [CUSTOMER]
ADD CONSTRAINT FK_CUSTOMER_CT_ID 
FOREIGN KEY ([CUSTOMER_TYPE_ID])
REFERENCES [CUSTOMER_TYPE](ID)
ON UPDATE CASCADE;
--SUPPLIER
ALTER TABLE [SUPPLIER]
ADD CONSTRAINT FK_SUPPLIER_EMPLOYEE_ID 
FOREIGN KEY ([EMPLOYEE_ID])
REFERENCES [EMPLOYEE](ID)
ON UPDATE CASCADE;
--IMPORT_HISTORY
ALTER TABLE [IMPORT_HISTORY]
ADD CONSTRAINT FK_IH_PRODUCTS_ID 
FOREIGN KEY ([PRODUCT_ID])
REFERENCES [PRODUCTS](ID)
ON UPDATE CASCADE;
------------------------
ALTER TABLE [IMPORT_HISTORY]
ADD CONSTRAINT FK_IH_SUPPLIER_ID 
FOREIGN KEY ([SUPPLIER_ID])
REFERENCES [SUPPLIER](ID)
ON UPDATE CASCADE;
--EMPLOYEE
ALTER TABLE [EMPLOYEE]
ADD CONSTRAINT FK_EMPLOYEE_FACILITY_ID 
FOREIGN KEY ([FACILITY_ID])
REFERENCES [FACILITY](ID)
ON UPDATE CASCADE;
--USERS
ALTER TABLE [USERS]
ADD CONSTRAINT FK_USERS_ROLES_ID 
FOREIGN KEY ([ROLE_ID])
REFERENCES [ROLES](ID)
ON UPDATE CASCADE;

GO 

--USE master
--DROP DATABASE PRO131_EF