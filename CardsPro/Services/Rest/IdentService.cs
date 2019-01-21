using CardsPro.Models.Dto;
using CardsPro.Models.Response;

namespace CardsPro.Services.Rest
{
    public class IdentService : BaseService
    {
        protected override string Name => "ident";

        public IdentService(IConfigurationService configurationService) : base(configurationService)
        {
        }

        /// <summary>
        /// Метод предназначен для проверки OTP-кода, отправленного в SMS на мобильный номер телефона клиента.
        /// </summary>
        /// <param name="dto">Параметры проверки OTP-кода.</param>
        public BaseResponse Check(IdentCheckDto dto) => Post<BaseResponse>("check", dto);

        /// <summary>
        /// Метод предназначен для отправки на мобильный номер телефона клиента SMS с OTP-кодом.
        /// </summary>
        /// <param name="dto">Параметры отправки OTP-кода.</param>
        public BaseResponse Send(IdentSendDto dto) => Post<BaseResponse>("send", dto);
    }
}