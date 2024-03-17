SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Tibor Szuntheimer
-- Create date: 2024.03.17.
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE dbo.spTeam_GetAll
AS
BEGIN
	SET NOCOUNT ON;

	select *
	from dbo.Teams;
END
GO
