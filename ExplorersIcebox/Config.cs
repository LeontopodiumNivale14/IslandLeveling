using System.Text.Json.Serialization;
using ECommons.Configuration;

namespace ExplorersIcebox;

public class Config : IEzConfig
{
    [JsonIgnore]
    public const int CurrentConfigVersion = 1;

    public int PalmLeafWorkshop = 0;
    public int BranchWorkshop = 0;
    public int StoneWorkshop = 0;
    public int ClamWorkshop = 0;
    public int LaverWorkshop = 0;
    public int CoralWorkshop = 0;
    public int IslewortWorkshop = 0;
    public int SandWorkshop = 0;
    public int VineWorkshop = 0; 
    public int SapWorkshop = 0;
    public int AppleWorkshop = 0;
    public int LogWorkshop = 0;
    public int PalmLogWorkshop = 0;
    public int CopperWorkshop = 0;
    public int LimestoneWorkshop = 0;
    public int RockSaltWorkshop = 0;
    public int ClayWorkshop = 0; 
    public int TinsandWorkshop = 0;
    public int SugarcaneWorkshop = 0;
    public int CottonWorkshop = 0;
    public int HempWorkshop = 0;
    public int IslefishWorkshop = 0;
    public int SquidWorkshop = 0;
    public int JellyfishWorkshop = 0;
    public int IronOreWorkshop = 0;
    public int QuartzWorkshop = 0;
    public int LeucograniteWorkshop = 0;
    public int MulticoloredIslebloomsWorkshop = 0;
    public int ResinWorkshop = 0;
    public int CoconutWorkshop = 0;
    public int BeehiveWorkshop = 0;
    public int WoodOpalWorkshop = 0;
    public int CoalWorkshop = 0;
    public int GlimshroomWorkshop = 0;
    public int EffervescentWaterWorkshop = 0;
    public int ShaleWorkshop = 0;
    public int MarbleWorkshop = 0;
    public int MythrilOreWorkshop = 0;
    public int SpectrineWorkshop = 0;
    public int DuriumSandWorkshop = 0;
    public int YellowCopperOreWorkshop = 0;     
    public int GoldOreWorkshop = 0;
    public int HawksEyeSandWorkshop = 0;
    public int CrystalFormationWorkshop = 0;

    public int routeSelected = 1;

    public void Save()
    {
        EzConfig.Save();
    }
}