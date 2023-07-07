create database Store;
--------------------------------------------------------------------------------------------------
CREATE TABLE [dbo].[tblCategory](
[Categoryid] [int] NOT NULL,
[Categoryname] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED
(
[Categoryid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS
= ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
-----------------------------------------------------------------------------------------------------
CREATE TABLE [dbo].[tblProduct](
[Productid] [int] NOT NULL,
[ProductName] [nvarchar](50) NULL,
[Categoryid] [int] NOT NULL
) ON [PRIMARY]

ALTER TABLE [dbo].[tblProduct] WITH CHECK ADD FOREIGN KEY([Categoryid])
REFERENCES [dbo].[tblCategory] ([Categoryid])
----------------------------------------------------------------------------------------------------------
select * from tblCategory
select * from tblProduct