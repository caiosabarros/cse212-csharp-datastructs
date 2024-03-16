using System.Reflection.Metadata.Ecma335;

public class FeatureCollection
{
    // Todo Earthquake Problem - ADD YOUR CODE HERE
    // Create additional classes as necessary
    public string type { get; set; }
    public Metadata metadata { get; set; }
    public List<Feature> features { get; set; }


}

public class Feature
{
    public string type { get; set; }
    public Properties properties { get; set; }
    public Geometry geometry { get; set; }
    public string id { get; set; }
}

public class Properties
{
    public decimal mag { get; set; }
    public string place { get; set; }
}
public class Geometry
{
    public string type { get; set; }
    public List<decimal> coordinates { get; set; }
}
public class Metadata
{
    public long generated { get; set; }
    public string url { get; set; }
    public string title { get; set; }
    public string api { get; set; }
    public int count { get; set; }
    public int status { get; set; }
}
