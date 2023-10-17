namespace FullStackAuth_WebAPI.DataTransferObjects
{
    public class BookDetailsDto
    {   
        public bool IsFavorited { get; set; }
        public List<ReviewWithUserDto> Reviews { get; set; }
        public  double AverageRating { get; set; }
    }
}
