/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [studid]
      ,[studname]
      ,[gender]
      ,[mobile]
      ,[email]
      ,[dob]
      ,[city]
  FROM [details].[dbo].[stud]