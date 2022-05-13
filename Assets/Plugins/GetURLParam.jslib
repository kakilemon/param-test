mergeInto(LibraryManager.library, {

  Hello: function () {
    window.alert("Hello, world!");
  },

  GetParam: function (paramName) {
    let url = new URL(window.location.href);
    let params = url.searchParams;
    let val = params.get(paramName);
    return val;
  }

});