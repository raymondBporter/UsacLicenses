using System.ComponentModel.DataAnnotations;

namespace Usac
{
    public class USACLicense
    {
        [Key]
        public string License { get; set; }
        public string Suspension { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Gender { get; set; }
        public string RacingAge { get; set; }
        public string ExpDate { get; set; }
        public string RdClub { get; set; }
        public string RdTeam { get; set; }
        public string TrackClub { get; set; }
        public string TrackTeam { get; set; }
        public string MtnClub { get; set; }
        public string MtnTeam { get; set; }
        public string CxClub { get; set; }
        public string CxTeam { get; set; }
        public string IntlTeam { get; set; }
        public string CollClub { get; set; }
        public string RoadCat { get; set; }
        public string TrackCat { get; set; }
        public string XcCat { get; set; }
        public string DhCat { get; set; }
        public string OtCat { get; set; }
        public string MxCat { get; set; }
        public string CrossCat { get; set; }
        public string BirthDate { get; set; }
        public string Citizen { get; set; }
        public string RdClubId { get; set; }
        public string RdTeamId { get; set; }
        public string TrackClubId { get; set; }
        public string TrackTeamId { get; set; }
        public string MtnClubId { get; set; }
        public string MtnTeamid { get; set; }
        public string CxClubId { get; set; }
        public string CxTeamId { get; set; }
        public string CollClubId { get; set; }
        public string UciCode { get; set; }
        public string CxRank { get; set; }
        public string HsClub { get; set; }
        public string HsTeam { get; set; }
        public string HsClubId { get; set; }
        public string HsTeamId { get; set; }
        public string UciId { get; set; }
        public string UciCategory { get; set; }
        public string Nationality { get; set; }
        public string Citizenship { get; set; }
        public string BMX { get; set; }
    }
}