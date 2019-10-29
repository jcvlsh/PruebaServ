public ActionResult Create()
{
    return View();
}
// POST: Movies/Create
// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
[HttpPost]
[ValidateAntiForgeryToken]
public async Task<ActionResult> Create([Bind(Include = "ID,Title,ReleaseDate,Genre,Price,Rating")] Movie movie)
{
    if (ModelState.IsValid)
    {
        db.Movies.Add(movie);
        await db.SaveChangesAsync();
        return RedirectToAction("Index");
    }

    return View(movie);
}