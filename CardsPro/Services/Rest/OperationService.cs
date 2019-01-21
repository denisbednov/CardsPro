using CardsPro.Models.Dto;
using CardsPro.Models.Response;

namespace CardsPro.Services.Rest
{
    public class OperationService : BaseService
    {
        protected override string Name => "operation";

        public OperationService(IConfigurationService configurationService) : base(configurationService)
        {
        }

        /// <summary>
        /// Технологическая отмена операции, выполняет отмену всего действия (чека) на всю сумму.
        /// </summary>
        /// <param name="dto">Параметры отмены.</param>
        public BaseResponse Cancel(CancelDto dto) => Post<BaseResponse>("cancel", dto);

        /// <summary>
        /// Получение списка операций.
        /// </summary>
        /// <param name="dto">Параметры запрашиваемых операций.</param>
        public OperationResponse Info(FindOperationsDto dto) => Post<OperationResponse>("info", dto);

        /// <summary>
        /// Получение расширенной информации об операции.
        /// </summary>
        /// <param name="dto">Параметры для получения расширенной информации об операции.</param>
        public OperationInfoExpandResponse InfoExpand(OperationInfoExpandDto dto) => Post<OperationInfoExpandResponse>("info/expand", dto);

        /// <summary>
        /// Возврат, согласованный клиентом или партнёром.
        /// </summary>
        /// <param name="dto">Параметры возврата.</param>
        public RefundResponse Refund(RefundDto dto) => Post<RefundResponse>("refund", dto);
    }
}