
function saveAsFile(fileName, byteString)
{
    var a = document.createElement('a');
    a.download = fileName;
    //a.href = 'data:application/octet-stream;base64,' + byteString;
    a.href = byteString;
    document.body.appendChild(a);
    a.click();
    document.body.removeChild(a);
};

function saveAsOFile(fileName, byteString) {
    var a = document.createElement('a');
    a.download = fileName;
    a.href = 'data:application/octet-stream;base64,' + byteString;
    //a.href = byteString;
    document.body.appendChild(a);
    a.click();
    document.body.removeChild(a);
};

