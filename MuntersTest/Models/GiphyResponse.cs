﻿namespace MuntersTest.Models
{
    public class GiphyResponse
    {
        public Data[] data { get; set; }
        public Pagination pagination { get; set; }
        public Meta meta { get; set; }
    }

    public class Pagination
    {
        public int total_count { get; set; }
        public int count { get; set; }
        public int offset { get; set; }
    }

    public class Meta
    {
        public int status { get; set; }
        public string msg { get; set; }
        public string response_id { get; set; }
    }

    public class Data
    {
        public string type { get; set; }
        public string id { get; set; }
        public string url { get; set; }
        public string slug { get; set; }
        public string bitly_gif_url { get; set; }
        public string bitly_url { get; set; }
        public string embed_url { get; set; }
        public string username { get; set; }
        public string source { get; set; }
        public string title { get; set; }
        public string rating { get; set; }
        public string content_url { get; set; }
        public string source_tld { get; set; }
        public string source_post_url { get; set; }
        public int is_sticker { get; set; }
        public string import_datetime { get; set; }
        public string trending_datetime { get; set; }
        public Images images { get; set; }
        public string analytics_response_payload { get; set; }
        public Analytics analytics { get; set; }
    }

    public class Images
    {
        public Original original { get; set; }
        public Fixed_Height fixed_height { get; set; }
        public Fixed_Height_Downsampled fixed_height_downsampled { get; set; }
        public Fixed_Height_Small fixed_height_small { get; set; }
        public Fixed_Width fixed_width { get; set; }
        public Fixed_Width_Downsampled fixed_width_downsampled { get; set; }
        public Fixed_Width_Small fixed_width_small { get; set; }
    }

    public class Original
    {
        public string height { get; set; }
        public string width { get; set; }
        public string size { get; set; }
        public string url { get; set; }
        public string mp4_size { get; set; }
        public string mp4 { get; set; }
        public string webp_size { get; set; }
        public string webp { get; set; }
        public string frames { get; set; }
        public string hash { get; set; }
    }

    public class Fixed_Height
    {
        public string height { get; set; }
        public string width { get; set; }
        public string size { get; set; }
        public string url { get; set; }
        public string mp4_size { get; set; }
        public string mp4 { get; set; }
        public string webp_size { get; set; }
        public string webp { get; set; }
    }

    public class Fixed_Height_Downsampled
    {
        public string height { get; set; }
        public string width { get; set; }
        public string size { get; set; }
        public string url { get; set; }
        public string webp_size { get; set; }
        public string webp { get; set; }
    }

    public class Fixed_Height_Small
    {
        public string height { get; set; }
        public string width { get; set; }
        public string size { get; set; }
        public string url { get; set; }
        public string mp4_size { get; set; }
        public string mp4 { get; set; }
        public string webp_size { get; set; }
        public string webp { get; set; }
    }

    public class Fixed_Width
    {
        public string height { get; set; }
        public string width { get; set; }
        public string size { get; set; }
        public string url { get; set; }
        public string mp4_size { get; set; }
        public string mp4 { get; set; }
        public string webp_size { get; set; }
        public string webp { get; set; }
    }

    public class Fixed_Width_Downsampled
    {
        public string height { get; set; }
        public string width { get; set; }
        public string size { get; set; }
        public string url { get; set; }
        public string webp_size { get; set; }
        public string webp { get; set; }
    }

    public class Fixed_Width_Small
    {
        public string height { get; set; }
        public string width { get; set; }
        public string size { get; set; }
        public string url { get; set; }
        public string mp4_size { get; set; }
        public string mp4 { get; set; }
        public string webp_size { get; set; }
        public string webp { get; set; }
    }

    public class Analytics
    {
        public Onload onload { get; set; }
        public Onclick onclick { get; set; }
        public Onsent onsent { get; set; }
    }

    public class Onload
    {
        public string url { get; set; }
    }

    public class Onclick
    {
        public string url { get; set; }
    }

    public class Onsent
    {
        public string url { get; set; }
    }

}
