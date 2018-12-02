namespace PokeOneWeb.ViewModels.GuideImport
{
    public class ItemViewModel
    {
        public string ItemName { get; set; }
        public int Count { get; set; }
        public string PlacementDescription { get; set; }
        public bool IsGift { get; set; }
        public string GiftNpcName { get; set; }
        public bool IsTrainerReward { get; set; }
        public bool IsQuestReward { get; set; }
        public bool IsHidden { get; set; }
    }
}
