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
-- Author:		<Rad3k>
-- Create date: <15.01.2013>
-- Description:	<Delete duplicates values>
-- =============================================
CREATE PROCEDURE delete_duplicates_values ( @id int )
AS
SET NOCOUNT ON;
BEGIN TRY
   BEGIN TRANSACTION 
    DELETE FROM Employee WHERE ID NOT IN (SELECT MIN(ID) FROM Employee GROUP BY Jmeno, Prijmeni, Email, RodneCislo)
	DELETE FROM TroubledEmployees WHERE ID NOT IN (SELECT MIN(ID) FROM TroubledEmployees GROUP BY Jmeno, Prijmeni)
	DELETE FROM ExternFile WHERE IdEmployee NOT IN (SELECT MIN(IdEmployee) FROM ExternFile GROUP BY IdFile, IdEmployee)
	COMMIT

END TRY
BEGIN CATCH
  -- Determine if an error occurred.
  IF @@TRANCOUNT > 0
     ROLLBACK

  -- Return the error information.
  DECLARE @ErrorMessage nvarchar(4000),  @ErrorSeverity int;
  SELECT @ErrorMessage = ERROR_MESSAGE(),@ErrorSeverity = ERROR_SEVERITY();
  RAISERROR(@ErrorMessage, @ErrorSeverity, 1);
END CATCH;

USE [Evidence]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Rad3k>
-- Create date: <15.01.2013>
-- Description:	<Delete duplicates values>
-- =============================================
ALTER PROCEDURE [dbo].[delete_duplicates_values] ( @id int )
AS
SET NOCOUNT ON;
BEGIN TRY
   BEGIN TRANSACTION 
	BEGIN TRANSACTION 
    DELETE FROM Employee WHERE ID NOT IN (SELECT MIN(ID) FROM Employee GROUP BY Jmeno, Prijmeni, Email, RodneCislo)
	DELETE FROM TroubledEmployees WHERE ID NOT IN (SELECT MIN(ID) FROM TroubledEmployees GROUP BY Jmeno, Prijmeni)
	DELETE FROM ExternFile WHERE IdEmployee NOT IN (SELECT MIN(IdEmployee) FROM ExternFile GROUP BY IdFile, IdEmployee)
	COMMIT

END TRY
BEGIN CATCH
  -- Determine if an error occurred.
  IF @@TRANCOUNT > 0
     ROLLBACK

  -- Return the error information.
  DECLARE @ErrorMessage nvarchar(4000),  @ErrorSeverity int;
  SELECT @ErrorMessage = ERROR_MESSAGE(),@ErrorSeverity = ERROR_SEVERITY();
  RAISERROR(@ErrorMessage, @ErrorSeverity, 1);
END CATCH;
GO
-- Execute the altered procedure.
EXEC dbo.delete_duplicates_values 15;