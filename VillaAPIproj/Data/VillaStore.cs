using VillaAPI.Models.DTO;

namespace VillaAPI.Data
{
    public class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>{
            new VillaDTO{Id=1, Name="abc Villa", Sqft=500,Occupancy=5},
            new VillaDTO{Id=2, Name="def Villa", Sqft=400,Occupancy=6},
             new VillaDTO{Id=3, Name="qwe Villa", Sqft=1000,Occupancy=8},
              new VillaDTO{Id=4, Name="poi Villa", Sqft=5000,Occupancy=3}
           };
    }
}
