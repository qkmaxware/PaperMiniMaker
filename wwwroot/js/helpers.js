function BlazorReadLocalStorage(name) {
    return window.localStorage.getItem(name);
}
function BlazorWriteLocalStorage(name, content) {
    return window.localStorage.setItem(name, content);
}

function BlazorDownloadFile(filename, contentType, content) {
    // Blazor marshall byte[] to a base64 string, so we first need to convert the string (content) to a Uint8Array to create the File
    const data = base64DecToArr(content);

    // Create the URL
    const file = new File([data], filename, { type: contentType });
    const exportUrl = URL.createObjectURL(file);

    // Create the <a> element and click on it
    const a = document.createElement("a");
    document.body.appendChild(a);
    a.href = exportUrl;
    a.download = filename;
    a.target = "_self";
    a.click();

    // We don't need to keep the url, let's release the memory
    // On Safari it seems you need to comment this line... (please let me know if you know why)
    URL.revokeObjectURL(exportUrl);
}

// Convert a base64 string to a Uint8Array. This is needed to create a blob object from the base64 string.
// The code comes from: https://developer.mozilla.org/fr/docs/Web/API/WindowBase64/D%C3%A9coder_encoder_en_base64
function b64ToUint6(nChr) {
  return nChr > 64 && nChr < 91 ? nChr - 65 : nChr > 96 && nChr < 123 ? nChr - 71 : nChr > 47 && nChr < 58 ? nChr + 4 : nChr === 43 ? 62 : nChr === 47 ? 63 : 0;
}

function base64DecToArr(sBase64, nBlocksSize) {
  var
    sB64Enc = sBase64.replace(/[^A-Za-z0-9\+\/]/g, ""),
    nInLen = sB64Enc.length,
    nOutLen = nBlocksSize ? Math.ceil((nInLen * 3 + 1 >> 2) / nBlocksSize) * nBlocksSize : nInLen * 3 + 1 >> 2,
    taBytes = new Uint8Array(nOutLen);

  for (var nMod3, nMod4, nUint24 = 0, nOutIdx = 0, nInIdx = 0; nInIdx < nInLen; nInIdx++) {
    nMod4 = nInIdx & 3;
    nUint24 |= b64ToUint6(sB64Enc.charCodeAt(nInIdx)) << 18 - 6 * nMod4;
    if (nMod4 === 3 || nInLen - nInIdx === 1) {
      for (nMod3 = 0; nMod3 < 3 && nOutIdx < nOutLen; nMod3++, nOutIdx++) {
        taBytes[nOutIdx] = nUint24 >>> (16 >>> nMod3 & 24) & 255;
      }
      nUint24 = 0;
    }
  }
  return taBytes;
}

async function BlazorReadFileAsBytes(file) {
  return await new Promise((resolve, reject) => {
    var reader = new FileReader();
    reader.onloadend = function(evt) {
      if (evt.target.readyState == FileReader.DONE) { // DONE == 2
        resolve(evt.target.result);
      } else {
        reject("");
      }
    }
    var blob = file.slice(0, file.size);
    reader.readAsText(blob);
  });
}

async function BlazorHandleFileSelect(input) {
  var files = input.files;
  if (files.length > 0) {
    var file = files[0];
    
    return await BlazorReadFileAsBytes(file);
  } else {
    return "";
  }
}

async function BlazorHandleFileSelectDataUrl(input) {
  var files = input.files;
  if (files.length > 0) {
    var file = files[0];
    
    return await BlazorReadFileAsDataUrl(file);
  } else {
    return "";
  }
}

function removeExtension(filename) {
  return filename.substring(0, filename.lastIndexOf('.')) || filename;
}

async function BlazorHandleFileSelectMultipleDataUrl(input) {
  var files = input.files;
  if (files.length > 0) {
    var data = {
      dataUrls: [],
      names: [],
    };
    for (var i = 0; i < files.length; i++) {
      var file = files[i];
      data.dataUrls.push(await BlazorReadFileAsDataUrl(file));
      data.names.push(removeExtension(file.name));
    }
    return data;
  } else {
    return {
      dataUrls: [],
      names: [],
    };
  }
}

async function BlazorReadFileAsDataUrl(file) {
  return await new Promise((resolve, reject) => {
    var reader = new FileReader();
    reader.onloadend = function(evt) {
      if (evt.target.readyState == FileReader.DONE) { // DONE == 2
        resolve(evt.target.result);
      } else {
        reject("");
      }
    }
    var blob = file.slice(0, file.size);
    reader.readAsDataURL(blob);
  });
}
