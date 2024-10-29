CREATE OR ALTER PROCEDURE dbo.Jedi_Search(
	@Name VARCHAR(100),
	@PageIndex INT = 1,
	@PageSize INT = 10
)
AS
BEGIN
	
	SET NOCOUNT ON;
	
	DECLARE  @FirstRow INT = (@PageIndex-1) * @PageSize

	SELECT 
		JediId, 
		[Name],
		Fila = ROW_NUMBER() OVER (ORDER BY J.[Name]),
		TotalFilas = COUNT(*) OVER()	
	FROM dbo.Jedi J
	WHERE
		(J.Name LIKE CONCAT('%',@Name,'%'))
	ORDER BY Fila 
	OFFSET @FirstRow ROWS
	FETCH NEXT @PageSize ROWS ONLY
   
END
GO
