namespace SP.PowerBI.DB.Entities.Dimension
{
    public class SkillSet : DBBasic
    {
        public int Level { set; get; } = 0;

        public string Description { set; get; } = string.Empty;

        public Team Team { set; get; }
    }
}