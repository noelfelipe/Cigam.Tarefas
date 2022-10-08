/****** Script do comando SelectTopNRows de SSMS  ******/
SELECT [IdTarefa]
      ,[Descricao]
      ,[Status]
  FROM [Tarefas].[dbo].[Tarefas]
  WHERE IdTarefa = 1 