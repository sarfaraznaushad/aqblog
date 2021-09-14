(function () {
    window.QuillFunctions = {
        createQuill: function (quillElement) {
            var options = {
                debug: 'info',                
                modules: {
                    syntax: true,
                    toolbar: '#toolbar'
                },
                placeholder: 'Compose an epic...',
                readOnly: false,
                theme: 'snow'
            };
            // set quill at the object we can call
            // methods on later
            new Quill(quillElement, options);
        },
        getQuillContent: function (quillControl) {
            return JSON.stringify(quillControl.__quill.getContents());
        },
        getQuillText: function (quillControl) {
            return quillControl.__quill.getText();
        },
        getQuillHTML: function (quillControl) {
            return quillControl.__quill.root.innerHTML;
        },
        loadQuillContent: function (quillControl, quillContent) {
            content = quillContent;
            return quillControl.__quill.root.innerHTML = content;
        },
        enableQuillEditor: function (quillControl, mode) {
            quillControl.__quill.enable(mode);
        }
    };
})();