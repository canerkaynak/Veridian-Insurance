document.addEventListener('DOMContentLoaded', () => {
    const card = document.getElementById('cardContainerId');

    const cardNumber = document.getElementById('cardNumberId');
    const cardNumberIllustrator = document.getElementById('cardNumberIllustratorId');

    const cardHolder = document.getElementById('cardHolderId');
    const cardHolderIllustrator = document.getElementById('cardHolderIllustratorId');

    const expireDate = document.getElementById('expireDateId');
    const expireDateIllustrator = document.getElementById('expireDateIllustratorId');

    const cvv = document.getElementById('cvvId');
    const cvvIllustrator = document.getElementById('cvvIllustratorId');

    cardNumber.addEventListener('input', (event) => {
        const input = event.target;
        let value = input.value.replace(/\D/g, '');
        value = value.match(/.{1,4}/g);
        if (value) {
            input.value = value.join(' ');
        }
        else {
            input.value = '';
        }
        cardNumberIllustrator.textContent = input.value;
    });

    cardHolder.addEventListener('input', (event) => {
        if (!event.target.value.replace(/[^a-zA-Z\s]/g, '')) {
            event.target.value = '';
            cardHolderIllustrator.textContent = '';
        }
        else {
            event.target.value = event.target.value.toUpperCase();
            cardHolderIllustrator.textContent = event.target.value.replace(/[^a-zA-Z\s]/g, '');
        }
    });

    expireDate.addEventListener('input', (event) => {
        expireDateIllustrator.textContent = event.target.value;
    });

    cvv.addEventListener('input', (event) => {
        const input = event.target;

        input.value = input.value.replace(/\D/g, '');
        cvvIllustrator.textContent = input.value;
    });

    expireDate.addEventListener('focus', () => {
        card.classList.add('flipped');
    });

    expireDate.addEventListener('focusout', () => {
        card.classList.remove('flipped');
    });

    cvv.addEventListener('focus', () => {
        card.classList.add('flipped');
    });

    cvv.addEventListener('focusout', () => {
        card.classList.remove('flipped');
    });
});