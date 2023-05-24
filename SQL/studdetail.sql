/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [studid]
      ,[rollno]
      ,[firstname]
      ,[lastname]
      ,[course]
      ,[city]
  FROM [details].[dbo].[studdetail]