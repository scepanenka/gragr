CREATE TABLE [dbo].[OperationsQuality]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [VerifierId] INT NOT NULL, 
    [QualityRate] INT NOT NULL, 
    [OperationId] UNIQUEIDENTIFIER NOT NULL, 
    [ControlTypeId] INT NOT NULL, 
    [Comment] NCHAR(100) NULL, 
    [QualityDocumentId] UNIQUEIDENTIFIER NULL, 
    CONSTRAINT [FK_OperationsQuality_Documents] FOREIGN KEY ([QualityDocumentId]) REFERENCES [Documents]([Id]), 
    CONSTRAINT [FK_OperationsQuality_QualityControlTypes] FOREIGN KEY ([ControlTypeId]) REFERENCES [QualityControlTypes]([Id]), 
    CONSTRAINT [FK_OperationsQuality_Employee] FOREIGN KEY ([VerifierId]) REFERENCES [Employees]([Id])
)
