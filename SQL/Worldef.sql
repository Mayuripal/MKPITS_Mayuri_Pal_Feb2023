create Database World;
---------------------------------------------------------------------------------------------------
CREATE TABLE [dbo].[tblState](
[stateid] [int] NOT NULL,
[statename] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED
(
[stateid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS
= ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
-----------------------------------------------------------------------------------------------------
CREATE TABLE [dbo].[tblCity](
[Cityid] [int] NOT NULL,
[CityName] [nvarchar](50) NULL,
[stateid] [int] NOT NULL
) ON [PRIMARY]

ALTER TABLE [dbo].[tblCity] WITH CHECK ADD FOREIGN KEY([stateid])
REFERENCES [dbo].[tblState] ([stateid])
------------------------------------------------------------------------------------------------------
select * from tblstate
select * from tblcity
-------------------------------------------------------------------------------------------------------
insert into tblstate values (1,'Maharashtra'),(2,'MP');

insert into tblCity values (1,'Nagpur',1),(2,'Mumbai',1),(3,'Bhopal',2),(4,'Indore',2);