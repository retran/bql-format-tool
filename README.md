bql-format-tool
===============

BQL formatting tool.
Feel free to embed it in any editor you like.

Usage:
------

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
