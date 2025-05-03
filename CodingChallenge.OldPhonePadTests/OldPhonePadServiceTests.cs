using CodingChallenge.OldPhonePadConsoleApp.OldPhonePad;

namespace CodingChallenge.OldPhonePadTests
{
    public class OldPhonePadServiceTests
    {
        private readonly OldPhonePadService _service;

        public OldPhonePadServiceTests()
        {
            _service = new OldPhonePadService();
        }

        [Theory]
        [InlineData("222 2 22","CAB")]
        [InlineData("33#", "E")]
        [InlineData("227*#", "B")]
        [InlineData("4433555 555666#", "HELLO")]
        [InlineData("8 88777444666*664#", "TURING")]
        public void OldPhonePadService_OldPhonePad_ShouldReturnString(string input, string expected)
        {
            var result = _service.OldPhonePad(input);
            Assert.Equal(expected, result);
        }
    }
}