using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;
using CsvHelper.Configuration;
using Usac;
using Utilities;

namespace UsacLicenses
{
    public static class Import
    {
        public const string DefaultFileName = "wp_p_universal.csv";

        public static List<USACLicense> FromCsv(Stream stream) =>
            CsvFiles.GetRecords<USACLicense, LicenseImportMap>(stream)
                .Select(CleanImportData)
                .ToList();

        private static USACLicense CleanImportData(USACLicense model) =>
            new USACLicense
            {
                Suspension = model.Suspension.Trim(),
                License = model.License.Trim().TrimStart('0'),
                LastName = model.LastName.Trim(),
                FirstName = model.FirstName.Trim(),
                City = model.City.Trim(),
                State = model.State.Trim(),
                Zip = model.Zip.Trim(),
                Gender = model.Gender.Trim(),
                RacingAge = model.RacingAge.Trim(),
                ExpDate = model.ExpDate.Trim(),
                RdClub = model.RdClub.Trim(),
                RdTeam = model.RdTeam.Trim(),
                TrackClub = model.TrackClub.Trim(),
                TrackTeam = model.TrackTeam.Trim(),
                MtnClub = model.MtnClub.Trim(),
                MtnTeam = model.MtnTeam.Trim(),
                CxClub = model.CxClub.Trim(),
                CxTeam = model.CxTeam.Trim(),
                IntlTeam = model.IntlTeam.Trim(),
                CollClub = model.CollClub.Trim(),
                RoadCat = model.RoadCat.Trim(),
                TrackCat = model.TrackCat.Trim(),
                XcCat = model.XcCat.Trim(),
                DhCat = model.DhCat.Trim(),
                OtCat = model.OtCat.Trim(),
                MxCat = model.MxCat.Trim(),
                CrossCat = model.CrossCat.Trim(),
                BirthDate = model.BirthDate.Trim(),
                Citizen = model.Citizen.Trim(),
                RdClubId = model.RdClubId.Trim(),
                RdTeamId = model.RdTeamId.Trim(),
                TrackClubId = model.TrackClubId.Trim(),
                TrackTeamId = model.TrackTeamId.Trim(),
                MtnClubId = model.MtnClubId.Trim(),
                MtnTeamid = model.MtnTeamid.Trim(),
                CxClubId = model.CxClubId.Trim(),
                CxTeamId = model.CxTeamId.Trim(),
                CollClubId = model.CollClubId.Trim(),
                UciCode = model.UciCode.Trim(),
                CxRank = model.CxRank.Trim(),
                HsClub = model.HsClub.Trim(),
                HsTeam = model.HsTeam.Trim(),
                HsClubId = model.HsClubId.Trim(),
                HsTeamId = model.HsTeamId.Trim(),
                UciId = model.UciId.Trim(),
                UciCategory = model.UciCategory.Trim(),
                Nationality = model.Nationality.Trim(),
                Citizenship = model.Citizenship.Trim(),
                BMX = model.BMX.Trim()
            };

        private sealed class LicenseImportMap : ClassMap<USACLicense>
        {
            public LicenseImportMap()
            {
                Map(model => model.Suspension).Name("Suspension");
                Map(model => model.License).Name("license#");
                Map(model => model.LastName).Name("last name");
                Map(model => model.FirstName).Name("first name");
                Map(model => model.City).Name("city");
                Map(model => model.State).Name("state");
                Map(model => model.Zip).Name("zip");
                Map(model => model.Gender).Name("gender");
                Map(model => model.RacingAge).Name("racing age");
                Map(model => model.ExpDate).Name("exp date");
                Map(model => model.RdClub).Name("Rdclub");
                Map(model => model.RdTeam).Name("Rdteam");
                Map(model => model.TrackClub).Name("Trackclub");
                Map(model => model.TrackTeam).Name("Trackteam");
                Map(model => model.MtnClub).Name("MTNclub");
                Map(model => model.MtnTeam).Name("MTNteam");
                Map(model => model.CxClub).Name("CXclub");
                Map(model => model.CxTeam).Name("CXteam");
                Map(model => model.IntlTeam).Name("IntlTeam");
                Map(model => model.CollClub).Name("Collclub");
                Map(model => model.RoadCat).Name("Road Cat");
                Map(model => model.TrackCat).Name("Track Cat");
                Map(model => model.XcCat).Name(" XC Cat");
                Map(model => model.DhCat).Name(" DH Cat");
                Map(model => model.OtCat).Name(" OT Cat");
                Map(model => model.MxCat).Name(" MX Cat");
                Map(model => model.CrossCat).Name("Cross Cat");
                Map(model => model.BirthDate).Name("birthdate");
                Map(model => model.Citizen).Name("citizen");
                Map(model => model.RdClubId).Name("RD Club id");
                Map(model => model.RdTeamId).Name("RD Team id");
                Map(model => model.TrackClubId).Name("Track Clubid");
                Map(model => model.TrackTeamId).Name(" Track Teamid");
                Map(model => model.MtnClubId).Name("MTN Clubid");
                Map(model => model.MtnTeamid).Name("MTN Teamid");
                Map(model => model.CxClubId).Name("CX Clubid");
                Map(model => model.CxTeamId).Name("CX Team id");
                Map(model => model.CollClubId).Name("Coll Clubid");
                Map(model => model.UciCode).Name("UCI Code");
                Map(model => model.CxRank).Name("CX Rank");
                Map(model => model.HsClub).Name("HS Club");
                Map(model => model.HsTeam).Name("HS Team");
                Map(model => model.HsClubId).Name("HS Club id");
                Map(model => model.HsTeamId).Name("HS Team id");
                Map(model => model.UciId).Name("UCI ID");
                Map(model => model.UciCategory).Name("UCI Category");
                Map(model => model.Nationality).Name("Nationality");
                Map(model => model.Citizenship).Name("Citizenship");
                Map(model => model.BMX).Name("BMX");
            }
        }
    }
}