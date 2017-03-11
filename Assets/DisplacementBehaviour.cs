using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplacementBehaviour : MonoBehaviour 
{
    private Material _mat;
    private RenderTexture _screenTex;
    private RenderTexture _waterMaskTex;

    public Texture _displacementTex;
    public Texture _waterTex;
    public float _turbulence = 1f;
    public float _scrollOffset = 0f;

    private GameObject _postRenderCamObj;
    private Camera _postRenderCam;
    private Camera _screenCam;

    void Awake() 
    {
        _screenTex = new RenderTexture(Screen.width, Screen.height, 24, RenderTextureFormat.Default);
        _screenTex.wrapMode = TextureWrapMode.Repeat;
        _waterMaskTex = new RenderTexture(Screen.width / 4, Screen.height / 4, 24, RenderTextureFormat.Default);
        _waterMaskTex.wrapMode = TextureWrapMode.Repeat;

        _screenCam = GetComponent<Camera>();
        _screenCam.SetTargetBuffers(_screenTex.colorBuffer, _screenTex.depthBuffer);
        CreatePostRenderCam();

        var shader = Shader.Find("Unlit/DisplacementShader");
        _mat = new Material(shader);
    }

    void OnPostRender()
	{
        _postRenderCam.CopyFrom(_screenCam);
        _postRenderCam.clearFlags = CameraClearFlags.SolidColor;
        _postRenderCam.backgroundColor = Color.black;
        _postRenderCam.cullingMask = 1 << LayerMask.NameToLayer("Water");
        _postRenderCam.targetTexture = _waterMaskTex;
        _postRenderCam.Render();

        _mat.SetTexture("_MaskTex", _waterMaskTex);
        _mat.SetTexture("_DisplacementTex", _displacementTex);
        _mat.SetTexture("_WaterTex", _waterTex);
        _mat.SetFloat("_Turbulence", _turbulence);
        _mat.SetFloat("_ScrollOffset", _scrollOffset);
        Graphics.Blit(_screenTex, null, _mat);
	}

    private void CreatePostRenderCam() 
    {
        _postRenderCamObj = new GameObject("PostRenderCam");
        _postRenderCamObj.transform.position = transform.position;
        _postRenderCamObj.transform.rotation = transform.rotation;
        _postRenderCam = _postRenderCamObj.AddComponent<Camera>();
        _postRenderCam.enabled = false;
    }
}
