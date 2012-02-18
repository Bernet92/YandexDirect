using Newtonsoft.Json;

namespace Yandex.Direct
{
    public class ForecastBannerPhraseInfo
    {
        /// <summary>����� ����� ��� ������������� ������� ������.�������� (� ����������� �� ��������� IsRubric)</summary>
        public string Phrase { get; set; }

        /// <summary>� �������� ����� ������������ ������� ������.�������� � Yes/No. ��� �������� Yes � ��������� Phrase ������ ������������� �������</summary>
        public BooleanType IsRubric { get; set; }

        /// <summary>���� �� ���� �� ������ ��������� ���� �������</summary>
        public decimal ContextPrice { get; set; }

        /// <summary>���������� ������ �� ����������, ���������� � ������� ������ ����� �� ������ �������</summary>
        public int Clicks { get; set; }

        /// <summary>���������� ������� ���������� �� ������ ����� �� ������ �������</summary>
        public int Shows { get; set; }

        /// <summary>��������� ���������������� ������ ����������</summary>
        public decimal Min { get; set; }

        /// <summary>��������� ������ ���������� �� ������ �����</summary>
        public decimal Max { get; set; }

        /// <summary>��������� ������ ���������� � ��������������</summary>
        public decimal PremiumMin { get; set; }

        /// <summary>��������� ������ ���������� �� ������ ����� � ��������������</summary>
        public decimal PremiumMax { get; set; }

        /// <summary>����� ����� ������ CTR � ����� ���� ������ ���������</summary>
        [JsonProperty("LowCTRWarning")]
        public BooleanType IsLowCtrWarning { get; set; }

        /// <summary>����� ��������� �� ������ �� ������ CTR</summary>
        [JsonProperty("LowCTR")]
        public BooleanType IsLowCtr { get; set; }

        /// <summary>����� ��������� �� ������ ��������� ���� ������� �� ������ CTR</summary>
        [JsonProperty("ContextLowCTR")]
        public BooleanType IsContextLowCtr { get; set; }

        /// <summary>�������������� ���������� ������ ��� ������ �� ������ �����</summary>
        public int FirstPlaceClicks { get; set; }

        /// <summary>�������������� ���������� ������ ��� ������ � ��������������</summary>
        public int PremiumClicks { get; set; }

        /// <summary>�������������� CTR ��� ������ �� ������ �����</summary>
        [JsonProperty("FirstPlaceCTR")]
        public decimal FirstPlaceCtr { get; set; }

        /// <summary>�������������� CTR ��� ������ � ��������������</summary>
        [JsonProperty("PremiumCTR")]
        public decimal PremiumCtr { get; set; }

        // TODO Create CoverageInfo class
        //public CoverageInfo[] Coverage { get; set; }
        //public CoverageInfo[] ContextCoverage { get; set; }
    }
}