using CardsPro.Models.Dto;
using CardsPro.Models.Response;

namespace CardsPro.Services.Rest
{
    public class UserService : BaseService
    {
        protected override string Name => "user";

        public UserService(IConfigurationService configurationService) : base(configurationService)
        {
        }

        /// <summary>
        /// Восстановление пароля от личного кабинета клиента.
        /// </summary>
        /// <param name="dto">Параметры восстановления пароля.</param>
        public BaseResponse PasswordRestore(PasswordRestoreDto dto) => Post<BaseResponse>("password/restore", dto);

        /// <summary>
        /// Метод предназначен для изменения/обновления анкетных данных клиента (кроме номера телефона).
        /// </summary>
        /// <param name="dto">Параметры изменения анкетных данных.</param>
        public BaseResponse InfoChange(InfoChangeDto dto) => Post<BaseResponse>("info/change", dto);
    }
}