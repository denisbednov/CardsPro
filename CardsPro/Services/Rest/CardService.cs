using CardsPro.Models.Dto;
using CardsPro.Models.Response;

namespace CardsPro.Services.Rest
{
    public class CardService : BaseService
    {
        protected override string Name => "card";

        public CardService(IConfigurationService configurationService) : base(configurationService)
        {
        }

        /// <summary>
        /// Метод предназначен для активации карты.
        /// </summary>
        /// <param name="dto">Параметры активации.</param>
        public BaseResponse Activate(ActivateDto dto) => Post<BaseResponse>("activate", dto);

        /// <summary>
        /// Вычисление максимально возможной суммы списания/скидки.
        /// </summary>
        /// <param name="dto">Параметры покупки (чека).</param>
        public CalculateDiscountResponse CalculateDiscount(PurchaseDto dto) => Post<CalculateDiscountResponse>("calculate/discount", dto);

        /// <summary>
        /// Вычисление предварительной суммы начисления по покупке (чеку).
        /// </summary>
        /// <param name="dto">Параметры покупки (чека).</param>
        public CalculateEarningResponse CalculateEarning(PurchaseDto dto) => Post<CalculateEarningResponse>("calculate/earning", dto);

        /// <summary>
        /// Изменение статуса карты. Данный метод предназначен для блокировки и разблокировки карты. Не стоит использовать этот метод для активации карты.
        /// </summary>
        /// <param name="dto">Параметры изменения статуса карты.</param>
        public BaseResponse ChangeStatus(CardChangeStatusDto dto) => Post<BaseResponse>("change_status", dto);

        /// <summary>
        /// Получение информации по карте.
        /// </summary>
        /// <param name="dto">Параметры карты.</param>
        public CardInfoResponse Info(FindInfoDto dto) => Post<CardInfoResponse>("info", dto);

        /// <summary>
        /// Выдача карты или привязка карты к одному балансу.
        /// </summary>
        /// <param name="dto">Параметры для выдачи карты или для привязки карт к одному балансу.</param>
        public CardIssueResponse Issue(IssueCardDto dto) => Post<CardIssueResponse>("issue", dto);

        /// <summary>
        /// Передача информации о покупке (чеке).
        /// </summary>
        /// <param name="dto">Параметры покупки (чека).</param>
        public PurchaseResponse Purchase(PurchaseDto dto) => Post<PurchaseResponse>("purchase", dto);

        /// <summary>
        /// Метод предназначен для поиска карт по номеру телефона клиента (держателя карты).
        /// </summary>
        /// <param name="dto">Параметры поиска.</param>
        public CardSearchResponse Search(SearchCardDto dto) => Post<CardSearchResponse>("search", dto);

        /// <summary>
        /// Пополнение карты.
        /// </summary>
        /// <param name="dto">Параметры пополнения.</param>
        public BaseResponse TopUp(TopUpDto dto) => Post<BaseResponse>("top_up", dto);

        /// <summary>
        /// Cписание средств с карты.
        /// </summary>
        /// <param name="dto">Параметры списания.</param>
        public WriteOffResponse WriteOff(WriteOffDto dto) => Post<WriteOffResponse>("write_off", dto);
    }
}