SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Tibor Szuntheimer
-- Create date: 2024.03.17.
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE dbo.spTournament_Insert
	@TournamentName nvarchar(200),
	@EntryFee money,
	@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

    insert into Tournaments (TournamentName, EntryFee, Active)
	values (@TournamentName, @EntryFee, 1);

	select @id = SCOPE_IDENTITY();
END
GO
