function safeHtmlRenderer(instance, td, row, col, prop, value, cellProperties) {
    // be sure you only allow certain HTML tags to avoid XSS threats
    // (you should also remove unwanted HTML attributes)
    td.innerHTML = Handsontable.helper.sanitize(value, {
        ALLOWED_TAGS: ['em', 'b', 'strong', 'a', 'big'],
    });
}

function createGrid(data) {
    const container = document.getElementById('grid-familia');
    const hot = new Handsontable(container, {
        data: data,
        rowHeaders: true,
        colHeaders: ['Responsável', 'Está recebendo cesta', 'Endereço', 'Número', 'Bairro', ''],
        className: 'htLeft',
        columns: [
            {
                data: 'Nome'
            },
            {
                data: 'EstaRecebendoCestaBasica',
                type: 'checkbox',
                className: 'htCenter'
            },
            {
                data: 'Logradouro',
            },
            {
                data: 'NumeroEndereco',
            },
            {
                data: 'Bairro',
            },
            {
                data: 'IdFamilia',
                renderer: safeHtmlRenderer
            }
        ],
        dropdownMenu: true,
        filters: true,
        height: 'auto',
        licenseKey: 'non-commercial-and-evaluation' // for non-commercial use only
    });

}