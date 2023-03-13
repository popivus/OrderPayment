SET ANSI_PADDING ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE DATABASE [OrderPaymentDB]
GO

USE [OrderPaymentDB]
GO

CREATE TABLE [dbo].[Order]
(
	[IdOrder] [int] NOT NULL IDENTITY(1,1),
	[Date] [date]  NOT NULL,
	[Sum] [money]  NOT NULL,
	[SumPaid] [money]  NOT NULL,

	CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED ([IdOrder] ASC) ON [PRIMARY],
)
GO

CREATE TABLE [dbo].[MoneyArrival]
(
	[IdMoneyArrival] [int] NOT NULL IDENTITY(1,1),
	[Date] [date]  NOT NULL,
	[Sum] [money]  NOT NULL,
	[SumRemaining] [money]  NOT NULL,

	CONSTRAINT [PK_MoneyArrival] PRIMARY KEY CLUSTERED ([IdMoneyArrival] ASC) ON [PRIMARY],
)
GO

CREATE OR ALTER FUNCTION [dbo].[GetRemainigSum_MoneyArrival](@IdMoneyArrival [int])
RETURNS [money]
AS
BEGIN
	RETURN (SELECT [SumRemaining] FROM [MoneyArrival] WHERE [IdMoneyArrival] = @IdMoneyArrival)
END
GO

CREATE OR ALTER FUNCTION [dbo].[GetRemainigSum_Order](@IdOrder [int])
RETURNS [money]
AS
BEGIN
	RETURN (SELECT ([Sum] - [SumPaid]) FROM [Order] WHERE [IdOrder] = @IdOrder)
END
GO

CREATE TABLE [dbo].[Payment]
(
	[IdPayment] [int] NOT NULL IDENTITY(1,1),
	[OrderId] [int]  NOT NULL,
	[MoneyArrivalId] [int]  NOT NULL,
	[Sum] [money]  NOT NULL,

	CONSTRAINT [PK_Payment] PRIMARY KEY CLUSTERED ([IdPayment] ASC) ON [PRIMARY],
	CONSTRAINT [CH_Sum_MoneyArrival] CHECK ([Sum] <= [dbo].[GetRemainigSum_MoneyArrival]([MoneyArrivalId])),
	CONSTRAINT [CH_Sum_Order] CHECK ([Sum] <= [dbo].[GetRemainigSum_Order]([OrderId]))
)
GO

ALTER TABLE [dbo].[Payment] WITH CHECK ADD CONSTRAINT [FK_Order_Payment] FOREIGN KEY ([OrderId])
REFERENCES [dbo].[Order]([IdOrder])
GO
ALTER TABLE [dbo].[Payment] CHECK CONSTRAINT [FK_Order_Payment]
GO

ALTER TABLE [dbo].[Payment] WITH CHECK ADD CONSTRAINT [FK_MoneyArrival_Payment] FOREIGN KEY ([MoneyArrivalId])
REFERENCES [dbo].[MoneyArrival]([IdMoneyArrival])
GO
ALTER TABLE [dbo].[Payment] CHECK CONSTRAINT [FK_MoneyArrival_Payment]
GO

CREATE OR ALTER TRIGGER [dbo].[UpdatingSums] on [dbo].[Payment]
AFTER INSERT
AS
	UPDATE [Order] SET [SumPaid] = [SumPaid] + (SELECT [Sum] FROM [inserted])
	WHERE [IdOrder] = (SELECT [OrderId] FROM [inserted])
	UPDATE [MoneyArrival] SET [SumRemaining] = [SumRemaining] - (SELECT [Sum] FROM [inserted])
	WHERE [IdMoneyArrival] = (SELECT [MoneyArrivalId] FROM [inserted])
GO