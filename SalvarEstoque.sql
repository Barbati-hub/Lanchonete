-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SalvarEstoque
	@Codigo nvarchar(200),
	@Descricao nvarchar(200),
	@Unidade int,
	@ValorDeCompra decimal,
	@QtdMax int,
	@QtdMin int,
	@Porcentagem int,
	@Categoria nvarchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   INSERT INTO Estoque
   (Codigo, Descricao,Unidade,ValorDeCompra,QtdMax,QtdMin,Porcentagem,Categoria)
   VALUES
  (@Codigo,@Descricao,@Unidade,@ValorDeCompra,@QtdMax,@QtdMin,@Porcentagem,@Categoria)
END
GO
