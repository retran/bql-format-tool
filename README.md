[![deprecated](http://badges.github.io/stability-badges/dist/deprecated.svg)](http://github.com/badges/stability-badges)

This is no longer supported.

bql-format-tool
===============

BQL formatting tool.
Feel free to embed it in any editor you like.

Usage
-----

stdin:
```
Search<PX.Objects.CR.Contact.contactID, Where<Optional<PX.Objects.GL.Batch.usrBAccountID>, Equal<PX.Objects.CR.Contact.bAccountID>>>
```

stdout:
```
Search<
    PX.Objects.CR.Contact.contactID,
    Where<
        Optional<
            PX.Objects.GL.Batch.usrBAccountID>,
        Equal<
            PX.Objects.CR.Contact.bAccountID>>>
```

Todos
-----
- [ ] integration with Visual Studio
- [ ] logical operations formating based on semantics
