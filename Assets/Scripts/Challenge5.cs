using UnityEngine;

public class Challenge5 : MonoBehaviour
{
    public string text;
    public string url;

    // Update is called once per frame
    void OnGUI()
    {
        Vector2 size = new Vector2(80, 20);

        Vector2 pos = Vector3.zero;
        for (Transform t = transform; t != null && t.position != null; t = t.parent)
        {
            pos += (Vector2)t.position;
        }
        pos -= (Vector2)Camera.main.transform.position;
        pos *= 200;
        pos += new Vector2(Screen.width / 2, Screen.height / 2);
        pos += size;

        if (GUI.Button(new Rect(pos.x, -pos.y, size.x, size.y), text))
        {
            Application.OpenURL(url);
        }
    }
}
