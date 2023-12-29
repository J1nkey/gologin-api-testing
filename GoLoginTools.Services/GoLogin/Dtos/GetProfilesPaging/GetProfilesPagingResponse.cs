namespace GoLoginTools.Services.GoLogin.Dtos.GetProfilesPaging
{
	public class GetProfilesPagingResponse
	{
		public List<ProfileDto> Profiles { get; set; }
        public int AllProfilesCount { get; set; }
    }
}
