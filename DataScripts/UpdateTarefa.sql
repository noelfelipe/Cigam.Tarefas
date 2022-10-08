USE [Tarefas]
GO

UPDATE [dbo].[Tarefas]
   SET [Descricao] = 'TESTE2'
      ,[Status] = 'P'
 WHERE IdTarefa = 1
GO


