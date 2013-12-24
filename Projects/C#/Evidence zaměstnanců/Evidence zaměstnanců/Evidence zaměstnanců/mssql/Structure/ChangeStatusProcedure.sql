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
CREATE PROCEDURE konec_smlouvy_zmena_statusu ( @id int )
AS
SET NOCOUNT ON;
BEGIN TRY
   BEGIN TRANSACTION 
	UPDATE dbo.Employee SET [Status] = '0' WHERE datumUkonceni < GETDATE()
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
ALTER PROCEDURE [dbo].[konec_smlouvy_zmena_statusu] ( @id int )
AS
SET NOCOUNT ON;
BEGIN TRY
   BEGIN TRANSACTION 
	UPDATE dbo.Employee SET [Status] = '0' WHERE datumUkonceni < GETDATE() and id = @id
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
EXEC dbo.konec_smlouvy_zmena_statusu 15;