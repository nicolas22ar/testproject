USE [test]
GO

INSERT INTO [dbo].[usuarios]([id],[nombre],[apellido],[email],[password])
VALUES (newid(),'nicolas','garcia','nicolas@email.com','1234')
GO
INSERT INTO [dbo].[usuarios]([id],[nombre],[apellido],[email],[password])
VALUES (newid(),'juan','perez','juan@email.com','1234')
GO
INSERT INTO [dbo].[usuarios]([id],[nombre],[apellido],[email],[password])
VALUES (newid(),'sultano','fernandez','sultano@email.com','1234')
GO
INSERT INTO [dbo].[usuarios]([id],[nombre],[apellido],[email],[password])
VALUES (newid(),'mengano','gonzalez','mengano@email.com','1234')
GO