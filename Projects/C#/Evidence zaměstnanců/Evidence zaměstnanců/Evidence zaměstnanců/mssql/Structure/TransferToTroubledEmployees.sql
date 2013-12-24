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
-- Create date: <24.12.2013>
-- Description:	<Transfer to troubled employees>
-- =============================================
CREATE PROCEDURE transfer_to_troubled_employees ( @id int )
AS
SET NOCOUNT ON;
BEGIN TRY
   BEGIN TRANSACTION 
    DECLARE @jmeno varchar(20), @prijmeni varchar(20)
	DECLARE subjekty CURSOR FOR 
      SELECT emp.id, emp.jmeno, emp.prijmeni FROM dbo.Employee emp
	  WHERE emp.Troubled = '1'

	OPEN subjekty

	FETCH NEXT FROM subjekty INTO @id, @jmeno, @prijmeni;

	WHILE @@FETCH_STATUS = 0
	BEGIN

        INSERT INTO dbo.TroubledEmployees VALUES (@id, @jmeno, @prijmeni, '')

		FETCH NEXT FROM subjekty INTO @id, @jmeno, @prijmeni;
	END 

	CLOSE subjekty
	DEALLOCATE subjekty
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
/****** Object:  StoredProcedure [dbo].[konec_smlouvy_zmena_statusu]    Script Date: 24.12.2013 16:40:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Rad3k>
-- Create date: <24.12.2013>
-- Description:	<Transfer to troubled employees>
-- =============================================
ALTER PROCEDURE [dbo].[transfer_to_troubled_employees] ( @id int )
AS
SET NOCOUNT ON;
BEGIN TRY
   BEGIN TRANSACTION 
	BEGIN TRANSACTION 
    DECLARE @jmeno varchar(20), @prijmeni varchar(20)
	DECLARE subjekty CURSOR FOR 
      SELECT emp.id, emp.jmeno, emp.prijmeni FROM dbo.Employee emp
	  WHERE emp.Troubled = '1'

	OPEN subjekty

	FETCH NEXT FROM subjekty INTO @id, @jmeno, @prijmeni;

	WHILE @@FETCH_STATUS = 0
	BEGIN

        INSERT INTO dbo.TroubledEmployees VALUES (@id, @jmeno, @prijmeni, '')

		FETCH NEXT FROM subjekty INTO @id, @jmeno, @prijmeni;
	END 

	CLOSE subjekty
	DEALLOCATE subjekty
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
EXEC dbo.transfer_to_troubled_employees 15;