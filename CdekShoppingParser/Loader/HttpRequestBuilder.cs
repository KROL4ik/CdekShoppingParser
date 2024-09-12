using System.Net.Http;

namespace CdekShoppingParser.Loader
{
    public class HttpRequestBuilder
    {
        public static HttpRequestMessage Create (string requestUri)
        {
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
            httpRequestMessage.Headers.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7");
            httpRequestMessage.Headers.Add("Accept-encoding", "gzip, deflate, br, zstd");
            httpRequestMessage.Headers.Add("Accept-language", "ru-RU,ru;q=0.9,en-US;q=0.8,en;q=0.7");
            httpRequestMessage.Headers.Add("Cache-control", "max-age=0");
            httpRequestMessage.Headers.Add("Cookie", "cart_id=eyJpdiI6Iko5aW5IVWJSUWVXelAxN3cvVTI1UUE9PSIsInZhbHVlIjoiQzZKM1NsWUMzZC9XaXp1N3Q0TVFuMUJKRVVDY1lMN1RoRkhXbmNoWDkxSFcrZzJCSjR5WHA4KzAyN3hSN2xJMURRTEh0R2hmVHczLzNYaERRQ1loT3dlOUlINUEyNGVOTHhyZ1I4eEZscjA9IiwibWFjIjoiNTkxNDFlYzM0NDJhZWZlYTlhNTZmODM1YWJkNGMyMzVlMmQ3MGQyZGM4ZWExNTczNWNmNTcwMzhlNjM4MDNiMCIsInRhZyI6IiJ9; popmechanic_sbjs_migrations=popmechanic_1418474375998%3D1%7C%7C%7C1471519752600%3D1%7C%7C%7C1471519752605%3D1; wishlist_id=eyJpdiI6IlpBSW5MWnptaEcyYkFnQkQrblU1UEE9PSIsInZhbHVlIjoiM3NVeXcyRDZvZG92Uzczc29XL1JIbzVyQ3J5Y2ZUOE15VFZKZmRvL2pYalhCVkY1di9zQU5XWWo2OXhqWG81K3l6OHZnSFZRS3JZaDlrVEVEQURxOE1mYkw2aDhZcURJQkFZb1p2djNBRFU9IiwibWFjIjoiNzlmNTA2YWMzNzkyYzczOTk0NTVmZDRhN2U3MWI0ZGE2MGYwMjM0NGU3MmIzMWE3NDk5NmQwMjdhNjMwMzQzOCIsInRhZyI6IiJ9; _ym_uid=172606468766035949; _ym_d=1726064687; st_uid=3064e7fcedf0cfaeadb63f5493f9; _ym_isad=1; mgo_uid=KZi2jV9Fo8o5jbW1FAVq; __cf_bm=NRDBbCnvLmaIbIufKg8OdL5E7uvFNrqfcF.cybX1kU4-1726067374-1.0.1.1-rKKpBaYEXRixCGykH4eurnTDweLaaqMuqzEChKz16Sh_Re5nemr55E0T.E94HpAUsMp8ULlkUXs0PrICCiSn7w; _ym_visorc=b; mgo_cnt=2; mgo_sid=8omjsjnm4111002gsuky; cf_clearance=kIp_8zdk6xGf_o0iMbqA6cZM58HtXD2RvQydrD2txW8-1726067377-1.2.1.1-ei1TJJBJr8YQVOLkFkcZ98jXwtfeJ8H8pMEic1HU5AufZNu9Flkm.J4kVCWQpv.Wzyi5djqm0bLpH9p.dvH89OM26_iUw207NOxm8ub48KCV0fxac4ODqMbNggLAPGoosF.13kTODN3I0jK.tOtox0H0u51h5KaID2b9gXQjarBNxzcecfmQGLCByTqKOsnQVIRuDUWQDoGsAy3Yeh6dwBn_WyFZpNRy1KWzNqQ7y_ITObowk2i1V6PnVXvYgmd1LJTZqpPc.Q5NmJUOg4GZu.rVROHvKuOlWWlKMz60nJjnn3.ACLO.jauPByZX894SWb2Fk_OJYbytFzAhbOGohlCvQ2V.42WIO8hduxi5F.WMJjdWXI86eQ80_uk1sSBG; mindboxDeviceUUID=a0d4d476-7a59-41c8-9f5a-f44223302a44; directCrm-session=%7B%22deviceGuid%22%3A%22a0d4d476-7a59-41c8-9f5a-f44223302a44%22%7D; XSRF-TOKEN=eyJpdiI6ImZVeWhJSG0zQVlONW5vaXNNVEppOEE9PSIsInZhbHVlIjoiV0hNSEM4YzR2YmtWL0NTcVEyckxjTHQ2ZTN0aFltSjgxeHZReHpUbzdjSFIvSGVKU2lvTDJLTlI4OWw2bEkraU1XeWI2MndPbEVqUzkxSVprckhOelR1SDlTNGQ4Y3ZURFMyVXhvQjRXVWg5RkNyYy8yVHhBMHd3UXhrUW9VZmciLCJtYWMiOiI3NzgzZjE0Mjg3OGU0N2JiNDFiODM4MWEzNGUyYTgyM2Y2ZGIwNDM5YzdlMjYyZmMwOGVlMzExMjc3MTdmYjQ4IiwidGFnIjoiIn0%3D; botble_session=eyJpdiI6Ijd0eUpMWnVSdWd2anVXYVF6UExYVmc9PSIsInZhbHVlIjoiWEEvMHNZZDVGT0UvcnNaQVllbjVWQU5CMWJOSFFFUm5NUjczbitNMmFrdkFLUWFjejdobDU0czVUamN5QS9FYyswZXBnOWtrNW1WWWRaODEwdWlMdG05VVg4OExGSThFV2tVcHRzbVptSkk5cDR6WU8rQ1QwdmhKZjVKZGRMMHYiLCJtYWMiOiI2NzQ0M2JmNTYwZGZlMGVhOWY1ZjljNWRhZTQ2Y2UxOTk1N2FjZTc1YTBiYTY1NDI1YTY5MWJlY2Q1NWE1MDU2IiwidGFnIjoiIn0%3D");
            httpRequestMessage.Headers.Add("Priority", "u=0, i");
            httpRequestMessage.Headers.Add("Referer", "https://cdek.shopping/?srsltid=AfmBOooJybx33b-_DSXPIoFdOWrM9AYYwvmQ4C4sAnfYD3KCCoavFXHr");
            httpRequestMessage.Headers.Add("Sec-ch-ua", "\"Chromium\";v=\"128\", \"Not;A=Brand\";v=\"24\", \"Google Chrome\";v=\"128\"");
            httpRequestMessage.Headers.Add("Sec-ch-ua-mobile", "?0");
            httpRequestMessage.Headers.Add("Sec-ch-ua-platform", "\"Windows\"");
            httpRequestMessage.Headers.Add("Sec-fetch-dest", "document");
            httpRequestMessage.Headers.Add("Sec-fetch-mode", "navigate");
            httpRequestMessage.Headers.Add("Sec-fetch-site", "same-origin");
            httpRequestMessage.Headers.Add("Sec-fetch-user", "?1");
            httpRequestMessage.Headers.Add("Upgrade-insecure-requests", "1");
            httpRequestMessage.Headers.Add("User-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/128.0.0.0 Safari/537.36");
            return httpRequestMessage;


        }
    }
}
