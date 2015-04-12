





Create Table SimplePortfolio
(
ItemId Identity(1,1) NOT NULL 
,
ItemName VARCHAR(50)
,Quantity INT
,UnitPrice DECIMAL (18,2)
, Total Quantity * UnitPrice
CONSTRAINT pk_ItemID PRIMARY KEY (ItemId)
