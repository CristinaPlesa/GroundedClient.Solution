
using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GroundedClient
{
  public class Emotion
  {
    public Emotion()
    {
      this.Emotions = new HashSet<Emotion>();
    }

    public int EmotionId { get; set; }
    public string EmotionName { get; set; }
    public virtual ICollection<Emotion> Emotions { get; set; }
  }
}