using UnityEngine;

public class Interactive : MonoBehaviour
{
    public enum InteractiveType { PICKABLE, INTERACT_ONCE, INTERACT_MULTI, INDIRECT };

    [SerializeField] private bool               _isActive;
    [SerializeField] private InteractiveType    _type;
    [SerializeField] private Sprite             _icon;
    [SerializeField] private string             _requirementText;
    [SerializeField] private Interactive[]      _requirements;
    [SerializeField] private Interactive[]      _activationChain;
    [SerializeField] private string[]           _interactionTexts;
    [SerializeField] private Interactive[]      _interactionChain;


    private Animator    _animator;
    private int         _curInteractionTextId;

    void Start()
    {
        _animator               = GetComponent<Animator>();
        _curInteractionTextId   = 0;
    }

    public bool IsActive()
    {
        return _isActive;
    }

    public InteractiveType GetInteractiveType()
    {
        return _type;
    }

    public Sprite GetIcon()
    {
        return _icon;
    }

    public string GetRequirementText()
    {
        return _requirementText;
    }

    public string GetCurrentInteractionText()
    {
        return _interactionTexts[_curInteractionTextId];
    }

    public Interactive[] GetRequirements()
    {
        return _requirements;
    }

    private void Activate()
    {
        _isActive = true;

        if (_animator != null)
            _animator.SetTrigger("Activate");
    }

    public void Interact()
    {
        if (_isActive)
        {
            if (_animator != null)
                _animator.SetTrigger("Interact");

            if (_type == InteractiveType.PICKABLE)
            {
                GetComponent<Collider>().enabled = false;
                gameObject.SetActive(false);
            }
            else if (_type == InteractiveType.INTERACT_ONCE)
                GetComponent<Collider>().enabled = false;
            else if (_type == InteractiveType.INTERACT_MULTI)
                _curInteractionTextId = (_curInteractionTextId + 1) % _interactionTexts.Length;

            ProcessActivationChain();
            ProcessInteractionChain();
        }
    }

    private void ProcessActivationChain()
    {
        if (_activationChain != null)
        {
            for (int i = 0; i < _activationChain.Length; ++i)
                _activationChain[i].Activate();
        }
    }

    private void ProcessInteractionChain()
    {
        if (_interactionChain != null)
        {
            for (int i = 0; i < _interactionChain.Length; ++i)
                _interactionChain[i].Interact();
        }
    }
}
