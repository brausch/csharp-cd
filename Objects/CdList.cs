using System.Collections.Generic;

namespace CdList.Objects
{
  public class Cd
  {
    private string _artist;
    private string _album;
    private int _id;
    private static List<Cd> _instances = new List<Cd> {};

    public Cd (string artist, string album)
    {
      _artist = artist;
      _album = album;
      _instances.Add(this);
      _id = _instances.Count;
    }
    public string GetArtist()
    {
      return _artist;
    }
    public void SetArtist(string newArtist)
    {
      _artist = newArtist;
    }
    public string GetAlbum()
    {
      return _album;
    }
    public void SetAlbum(string newAlbum)
    {
      _album = newAlbum;
    }
    public int GetId()
    {
      return _id;
    }
    public static List<Cd> GetAll()
    {
      return _instances;
    }
    public static Cd Find(int searchId)
    {
      return _instances[searchId -1];
    }
  }
}
