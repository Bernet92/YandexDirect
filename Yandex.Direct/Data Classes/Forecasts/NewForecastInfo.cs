using Newtonsoft.Json;

namespace Yandex.Direct
{
    [JsonObject]
    internal class CreateForecastInfo
    {
        /// <summary>������, ���������� �������������� ��������� ������.��������, ��� ������� ��������� �������� �������</summary>
        public int[] Categories { get; set; }

        /// <summary>������ ����, ��� ������� ��������� �������� ������� (�� ����� 100)</summary>
        public string[] Phrases { get; set; }

        /// <summary>������, ���������� �������������� �������� ��� ����������� ��������. ���� �� �����, ������� ������������ �� ���� ��������</summary>
        [JsonProperty("GeoID")]
        public int[] GeoIds { get; set; }
    }
}