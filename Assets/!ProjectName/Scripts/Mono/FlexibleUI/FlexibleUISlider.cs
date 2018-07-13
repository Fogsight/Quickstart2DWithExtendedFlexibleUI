using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
[RequireComponent(typeof(CollectionItemUI))]
public class FlexibleUISlider : FlexibleUI {
    private Image[] images;

    public override void OnSkinUI() {
        base.OnSkinUI();
        images = GetComponentsInChildren<Image>();
        for (int i = 0; i < images.Length; i++) {
            images[i].sprite = flexibleUIData.sprites[i];
            images[i].color = flexibleUIData.color;
        }
    }
}